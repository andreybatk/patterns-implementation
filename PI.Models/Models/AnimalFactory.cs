using PI.Models.Infrastructure;

namespace PI.Models.Models
{
    public static class AnimalFactory
    {
        /// <summary>
        /// Get Animal
        /// </summary>
        /// <param name="animalType">Тип: Amphibian, Bird, Mammal, null</param>
        /// <param name="kindOfAnimal">Вид</param>
        /// <param name="age">Возраст</param>
        /// <returns>Экземпляр реализующий IAnimal</returns>
        public static IAnimal GetAnimal(string? animalType, string kindOfAnimal, int age)
        {
            switch (animalType)
            {
                case "Amphibian": return new Amphibian(kindOfAnimal, age);
                case "Bird": return new Bird(kindOfAnimal, age);
                case "Mammal": return new Mammal(kindOfAnimal, age);
                default: return new Animal(kindOfAnimal, age);
            }
        }
    }
}
