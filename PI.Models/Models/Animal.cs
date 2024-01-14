using PI.Models.Infrastructure;

namespace PI.Models.Models
{
    public class Animal : IAnimal
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
