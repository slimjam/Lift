using Lift.buisness_logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.Controllers
{
    public class ButtonController : IButtonController
    {
        //public List<FloorButton> floorButtons;

        /*public bool ChangeState(LiftState newState)
        {
            return false;
        }*/     //replace to manager
        public ButtonManager manager;
        public ButtonController()
        {
            manager = new ButtonManager();
        }
    }
}
