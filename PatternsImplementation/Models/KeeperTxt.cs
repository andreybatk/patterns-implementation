using FactoryPattern.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace FactoryPattern.Models
{
    internal class KeeperTxt : IDataSave
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
            
            using(StreamReader reader = new StreamReader($"{_file}.txt"))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                }

                return new List<IAnimal>();
            }
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
