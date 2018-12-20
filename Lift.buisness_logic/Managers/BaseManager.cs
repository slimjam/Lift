using System;
using System.Collections.Generic;

namespace Lift.buisness_logic
{
    public class BaseManager : SystemManager, IManager<IModel>
    {
        public List<IModel> items;
        public BaseManager()
        {
            items = new List<IModel>();
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
