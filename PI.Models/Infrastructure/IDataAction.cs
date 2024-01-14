namespace PI.Models.Infrastructure
{
    public interface IDataAction
    {
        void SaveData(List<IAnimal> animals);
        List<IAnimal> LoadData();
    }
}
