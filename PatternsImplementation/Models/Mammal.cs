using FactoryPattern.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Models
{
    internal class Mammal : Animal, IAnimal
    {
        public Mammal(string kindOfAnimal, int age) : base(kindOfAnimal, age) { this.Type = "Млекопитающие"; }
    }
}
