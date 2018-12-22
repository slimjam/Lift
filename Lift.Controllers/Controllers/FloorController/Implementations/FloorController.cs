using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lift.buisness_logic;

namespace Lift.Controllers
{
    public class FloorController
    {
        public FloorManager manager;
        public FloorController()
        {
            manager = new FloorManager();
        }
    }
}
