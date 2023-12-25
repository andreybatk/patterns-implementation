using FactoryPattern.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Models
{
    internal class Bird : Animal, IAnimal
    {
        public Bird(string kindOfAnimal, int age) : base(kindOfAnimal, age) { this.Type = "Птицы"; }
    }
}
