using FactoryPattern.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Models
{
    internal class Animal : IAnimal
    {
        public Animal(string kindOfAnimal, int age)
        {
            this.Age = age;
            this.KindOfAnimal = kindOfAnimal;
            this.Type = "Not Determined";
        }

        public int Age { get; set; }
        public string Type { get; set; }
        public string KindOfAnimal { get; set; }
    }
}
