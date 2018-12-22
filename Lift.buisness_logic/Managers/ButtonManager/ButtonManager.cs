using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.buisness_logic
{
    public class ButtonManager : BaseManager
    {
        internal bool IsActiveAnyButtons()
        {
            foreach(FloorButton button in items)
            {
                if (button.IsPressed)
                {
                    return true;                    
                }                
            }
            return false;
        }

        internal LiftState GetDirection(int currentFloor)
        {
            var state = LiftState.StayClose;
            foreach (FloorButton button in items)
            {
                if (button.IsPressed)
                {                    
                    if (currentFloor > button.number) { state = LiftState.GoDown; }
                    else { if (currentFloor < button.number) { state = LiftState.GoUp; } }
                    return state;
                }
            }
            return state;
        }
    }
}
