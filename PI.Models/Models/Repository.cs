using PI.Models.Infrastructure;

namespace PI.Models.Models
{
    public class Repository
    {
        public Repository(IDataAction Method)
        {
            this.Mode = Method;
            this.Animals = new List<IAnimal>();
        }

        public IDataAction Mode { get; set; }
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
