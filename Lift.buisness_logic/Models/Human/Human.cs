using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.buisness_logic.Models.Human
{
    class Human
    {
        public readonly int weidth;
        public readonly int targertFloor;
        public readonly int currentFloor;
        public readonly int startFloor;
        Human(int _weidth, int _targertFloor, int _currentFloor, int _startFloor)
        {
            weidth = _weidth;
            targertFloor = _targertFloor;
            currentFloor = _currentFloor;
            startFloor = _startFloor;
        }
    }
}
