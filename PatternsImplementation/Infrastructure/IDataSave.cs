using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Infrastructure
{
    internal interface IDataSave
    {
        void SaveData(List<IAnimal> animals);
        List<IAnimal> LoadData();
    }
}
