using PI.Models.Infrastructure;
using PI.Models.Models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MVP
{
    internal class Model
    {
        public Model()
        {
            Repository = new Repository(new KeeperJson("animals"));
            Animals = Repository.Animals;
        }

        public ObservableCollection<IAnimal> Animals;
        public Repository Repository;

        public void Save()
        {
            try
            {
                Repository.Save();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        public void Load()
        {
            try
            {
                Repository.Load();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        public void Add(IAnimal animal)
        {
            try
            {
                Repository.Add(animal);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        public void Delete(IAnimal animal)
        {
            try
            {
                Animals.Remove(animal);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}