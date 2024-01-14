using Newtonsoft.Json;
using PI.Models.Infrastructure;
using System.Text;

namespace PI.Models.Models
{
    public class KeeperJson : IDataAction
    {
        private string _file;

        public KeeperJson(string file)
        {
            this._file = file;
        }

        public List<IAnimal> LoadData()
        {
            if (!File.Exists($"{_file}.json"))
            {
                throw new FileNotFoundException("Файл не найден.");
            }

            string json = File.ReadAllText($"{_file}.json", Encoding.UTF8);
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            var obj = JsonConvert.DeserializeObject<List<IAnimal>>(json, settings);
            return obj;
        }

        public void SaveData(List<IAnimal> animals)
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            string json = JsonConvert.SerializeObject(animals, settings);
            File.WriteAllText($"{_file}.json", json);
        }
    }
}
