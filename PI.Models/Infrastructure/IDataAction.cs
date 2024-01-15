using System.Collections.ObjectModel;

namespace PI.Models.Infrastructure
{
    public interface IDataAction
    {
        void SaveData(ObservableCollection<IAnimal> animals);
        ObservableCollection<IAnimal> LoadData();
    }
}
