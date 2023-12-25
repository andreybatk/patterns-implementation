using FactoryPattern.Infrastructure;
using FactoryPattern.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Models
{
    internal class Repository// : ViewModel
    {
        //private List<IAnimal> _animals;
        public Repository(IDataSave Method)
        {
            this.Mode = Method;
            this.Animals = new List<IAnimal>();
        }

        public IDataSave Mode { get; set; }
        //public List<IAnimal> Animals { get => _animals; set => Set(ref _animals, value); }
        public List<IAnimal> Animals { get; set; }

        public void Save()
        {
            Mode.SaveData(Animals);
        }
        public void Load()
        {
            Animals = Mode.LoadData();
        }
    }
}
