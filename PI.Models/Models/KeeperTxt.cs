using PI.Models.Infrastructure;

namespace PI.Models.Models
{
    public class KeeperTxt : IDataAction
    {
        private string _file;

        public KeeperTxt(string file)
        {
            this._file = file;
        }

        public List<IAnimal> LoadData()
        {
            if(!File.Exists($"{_file}.txt"))
            {
                throw new FileNotFoundException("Файл не найден.");
            }

            return null;
        }

        public void SaveData(List<IAnimal> animals)
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
