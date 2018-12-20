using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lift.buisness_logic
{
    public class Building : IModel
    {
        public readonly Lift lift;
        public readonly Floor[] floors;
    }
}
