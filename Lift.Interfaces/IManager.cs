using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.buisness_logic
{
    public interface IManager<IModel>
    {
        void AddItem(IModel item);
        void RemoveItem(IModel item);
        IModel CreateItem();
        void DeleteItem(IModel item);
    }
}
