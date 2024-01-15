using PI.Models.Infrastructure;
using System.Collections.ObjectModel;
using System.Windows;

namespace MVP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        Presenter p;
        public MainWindow()
        {
            InitializeComponent();
            p = new Presenter(this);

            btnSave.Click += (s, e) => p.Save();
            btnLoad.Click += (s, e) => p.Load();
            itemDelete.Click += (s, e) => p.Delete(lvAnimals.SelectedItem as IAnimal);
            itemAdd.Click += (s, e) => p.Add();
        }
        public ObservableCollection<IAnimal> Animals { set => lvAnimals.ItemsSource = value; }
    }
}
