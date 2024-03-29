﻿using PI.Models.Infrastructure;

namespace PI.Models.Models
{
    public static class AnimalFactory
    {
        /// <summary>
        /// Получить экземпляр животного
        /// </summary>
        /// <param name="animalType">Тип: Amphibian, Bird, Mammal (птицы, млекопитающие, земноводные) null</param>
        /// <param name="kindOfAnimal">Вид</param>
        /// <param name="age">Возраст</param>
        /// <returns>Экземпляр реализующий IAnimal</returns>
        public static IAnimal GetAnimal(string? animalType, string kindOfAnimal, int age)
        {
            switch (animalType?.Trim().ToLower())
            {
                case "птицы":
                    animalType = "Bird";
                    break;
                case "млекопитающие":
                    animalType = "Mammal";
                    break;
                case "земноводные":
                    animalType = "Amphibian";
                    break;
            }

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