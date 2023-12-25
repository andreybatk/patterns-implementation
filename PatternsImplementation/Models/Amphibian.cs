using FactoryPattern.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Models
{
    internal class Amphibian : Animal, IAnimal
    {
        public Amphibian(string kindOfAnimal, int age) : base(kindOfAnimal, age) { this.Type = "Земноводные"; }
    }
}
