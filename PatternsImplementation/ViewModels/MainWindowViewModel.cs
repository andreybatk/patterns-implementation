using MVVM.Infrastructure.Commands;
using MVVM.ViewModels.Base;
using PI.Models.Infrastructure;
using PI.Models.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private ObservableCollection<IAnimal> _animals;
        private Repository _repository;

        public MainWindowViewModel()
        {
            _repository = new Repository(new KeeperJson("animals"));

            Animals = _repository.Animals;

            SaveDataCommand = new RelayCommand(OnSaveDataCommandExecuted);
            LoadDataCommand = new RelayCommand(OnLoadDataCommandExecuted);
        }

        public ObservableCollection<IAnimal> Animals { get => _animals; set => Set(ref _animals, value); }
        public ICommand SaveDataCommand { get; }
        public ICommand LoadDataCommand { get; }

        private void OnSaveDataCommandExecuted(object p)
        {
            try
            {
                _repository.Save();
                MessageBox.Show("Данные сохранены!", "Сохранение", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
        private void OnLoadDataCommandExecuted(object p)
        {
            try
            {
                _repository.Load();
                MessageBox.Show("Данные загружены!", "Загрузка", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}