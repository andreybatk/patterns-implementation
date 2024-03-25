using Newtonsoft.Json;
using PI.Models.Infrastructure;
using System.Collections.ObjectModel;
using System.Text;

namespace PI.Models.Models
{
    public class KeeperJson : IDataAction
    {
        private string _file;

        public KeeperJson(string file)
        {
            _file = file;
        }

        public ObservableCollection<IAnimal> LoadData()
        {
            if (!File.Exists($"{_file}.json"))
            {
                throw new FileNotFoundException("Файл не найден.");
            }

            string json = File.ReadAllText($"{_file}.json", Encoding.UTF8);
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            var obj = JsonConvert.DeserializeObject<ObservableCollection<IAnimal>>(json, settings);
            return obj;
        }

        public void SaveData(ObservableCollection<IAnimal> animals)
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            string json = JsonConvert.SerializeObject(animals, settings);
            File.WriteAllText($"{_file}.json", json);
        }
    }
}