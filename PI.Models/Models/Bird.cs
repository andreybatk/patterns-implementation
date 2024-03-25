using PI.Models.Infrastructure;

namespace PI.Models.Models
{
    public class Bird : Animal, IAnimal
    {
        public Bird(string kindOfAnimal, int age) : base(kindOfAnimal, age) { Type = "Птицы"; }
    }
}
