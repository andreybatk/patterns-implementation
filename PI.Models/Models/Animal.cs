using PI.Models.Infrastructure;

namespace PI.Models.Models
{
    public class Animal : IAnimal
    {
        public Animal(string kindOfAnimal, int age)
        {
            Age = age;
            KindOfAnimal = kindOfAnimal;
            Type = "Not Determined";
        }

        public int Age { get; set; }
        public string Type { get; set; }
        public string KindOfAnimal { get; set; }
    }
}