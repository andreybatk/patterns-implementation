using PI.Models.Infrastructure;

namespace PI.Models.Models
{
    public class Mammal : Animal, IAnimal
    {
        public Mammal(string kindOfAnimal, int age) : base(kindOfAnimal, age) { this.Type = "Млекопитающие"; }
    }
}
