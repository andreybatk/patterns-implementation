using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Infrastructure
{
    internal interface IAnimal
    {
        public int Age { get; set; }
        public string Type { get; set; }
        public string KindOfAnimal { get; set; }
    }
}
