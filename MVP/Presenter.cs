using PI.Models.Infrastructure;
using PI.Models.Models;

namespace MVP
{
    internal class Presenter
    {
        public IView view;
        public Model model;

        public Presenter(IView View)
        {
            this.view = View;

            model = new Model();
        }
        public void Save()
        {
            model.Save();
        }
        public void Load()
        {
            model.Load();
            view.Animals = model.Animals;
        }
        public void Delete(IAnimal? animal)
        {
            if (animal != null)
            {
                model.Delete(animal);
            }
        }
        public void Add()
        {
            AddAnimal addAnimal = new AddAnimal();

            addAnimal.ShowDialog();

            if (addAnimal.DialogResult.Value)
            {
                model.Add(AnimalFactory.GetAnimal(addAnimal.Type, addAnimal.KindOfAnimal, addAnimal.Age));
            }
        }
    }
}