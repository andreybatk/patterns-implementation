using PI.Models.Infrastructure;
using System.Collections.ObjectModel;

namespace PI.Models.Models
{
    public class Repository
    {
        public Repository(IDataAction Method)
        {
            this.Mode = Method;
            this.Animals = new ObservableCollection<IAnimal>();
        }

        public IDataAction Mode { get; set; }
        public ObservableCollection<IAnimal> Animals { get; set; }

        public void Add(IAnimal animal)
        {
            Animals.Add(animal);
        }
        public void Save()
        {
            Mode.SaveData(Animals);
        }
        public void Load()
        {
            var LoadedAnimals = Mode.LoadData();
            foreach (var item in LoadedAnimals)
            {
                Animals.Add(item);
            }
        }
    }
}
