using PI.Models.Infrastructure;
using System.Collections.ObjectModel;

namespace MVP
{
    internal interface IView
    {
        ObservableCollection<IAnimal> Animals { set; }
    }
}
