using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.buisness_logic
{
    public abstract class BaseButton : IModel
    {
        public bool IsPressed { get; set; }
    }
}
