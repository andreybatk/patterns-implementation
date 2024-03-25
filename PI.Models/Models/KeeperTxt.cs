using PI.Models.Infrastructure;
using System.Collections.ObjectModel;

namespace PI.Models.Models
{
    public class KeeperTxt : IDataAction
    {
        private string _file;

        public KeeperTxt(string file)
        {
            _file = file;
        }

        public ObservableCollection<IAnimal> LoadData()
        {
            if (!File.Exists($"{_file}.txt"))
            {
                throw new FileNotFoundException("Файл не найден.");
            }

            return null;
        }

        public void SaveData(ObservableCollection<IAnimal> animals)
        {
            using (StreamWriter sw = new StreamWriter($"{_file}.txt"))
            {
                foreach (var animal in animals)
                {
                    sw.WriteLine(animal);
                }
            }
        }
    }
}