using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lift.buisness_logic;

namespace Lift.Controllers
{
    public class LiftController
    {
        public LiftManager manager;
        public LiftController()
        {
            manager = new LiftManager();
        }
    }
}
