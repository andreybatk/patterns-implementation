using FactoryPattern.Infrastructure;
using FactoryPattern.Infrastructure.Commands;
using FactoryPattern.Models;
using FactoryPattern.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FactoryPattern.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private List<IAnimal> _animals;
        private Repository _repository;

        public MainWindowViewModel()
        {
            _repository = new Repository(new KeeperJson("animals"));

            _animals = _repository.Animals;
            //Animals.Add(AnimalFactory.GetAnimal(null, "Собака", 10));
            //Animals.Add(AnimalFactory.GetAnimal("Bird", "Ястреб", 2));

            SaveDataCommand = new RelayCommand(OnSaveDataCommandExecuted);
            LoadDataCommand = new RelayCommand(OnLoadDataCommandExecuted);
        }
        public List<IAnimal> Animals { get => _animals; set => Set(ref _animals, value); }
        public ICommand SaveDataCommand { get; }
        public ICommand LoadDataCommand { get; }

        private void OnSaveDataCommandExecuted(object p)
        {
            try
            {
                _repository.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }
        private void OnLoadDataCommandExecuted(object p)
        {
            try
            {
                _repository.Load();
                Animals = _repository.Animals;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }
    }
}
