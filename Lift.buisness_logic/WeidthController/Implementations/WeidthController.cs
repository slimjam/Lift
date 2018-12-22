using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.buisness_logic
{
    public class WeidthController
    {
        private int weidthLimit;
        public bool IsOverload(int weidth)
        {
            return weidth > weidthLimit;
        }
    }
}
