using Lift.buisness_logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.buisness_logic.Controllers
{
    interface IController<Controlable>
    {
        void AddItem(Controlable item);
        void RemoveItem(Controlable item);
        Controlable CreateItem();
        void DeleteItem(Controlable item);
    }

    class Controller : IController<Controlable>
    {
        private List<Controlable> items;
        public Controller()
        {
            items = new List<Controlable>();
        }
        public void AddItem(Controlable item)
        {
            items.Add(item);
        }

        public Controlable CreateItem()
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Controlable item)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(Controlable item)
        {
            items.Remove(item);
        }
    }
}
