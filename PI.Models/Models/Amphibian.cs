using PI.Models.Infrastructure;

namespace PI.Models.Models
{
    public class Amphibian : Animal, IAnimal
    {
        public Amphibian(string kindOfAnimal, int age) : base(kindOfAnimal, age) { this.Type = "Земноводные"; }
    }
}
