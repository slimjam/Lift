using System;
using System.Collections.Generic;

namespace Lift.buisness_logic
{
    public class BaseManager : IManager<IModel>
    {
        public SystemManager mainManager;
        public List<IModel> items;
        public BaseManager(SystemManager manager=null)
        {
            items = new List<IModel>();
            mainManager = manager;
        }
        public void AddItem(IModel item)
        {
            items.Add(item);
        }

        public IModel CreateItem()
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(IModel item)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(IModel item)
        {
            items.Remove(item);
        }
    }
}
