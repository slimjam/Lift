using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lift.buisness_logic.Models.Lift;
using Lift.buisness_logic.Models.Button;

namespace Lift.buisness_logic.Controllers.ButtonController.Implementations
{
    class ButtonController : IButtonController
    {
        private FloorButton[] floorButtons; 
        public bool ChangeState(LiftState newState)
        {
            return false;
        }
    }
}
