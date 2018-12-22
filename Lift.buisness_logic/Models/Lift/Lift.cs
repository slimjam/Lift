using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.buisness_logic
{
    public enum LiftState
    {
        GoUp,
        GoDown,
        StayClose,
        StayOpen
    }
    public class Lift : IModel
    {
        public readonly List<FloorButton> buttons;
        public readonly GoButton goButton;
        public readonly int weidthLimit;
        public int floorNumber = 1;    // first floor
        public readonly WeidthController weidthController;
        public List<Human> humen;
        // TODO valid mthod to managr
        public LiftState State {
            get
            {
                return this.State;
            }
            set
            {
                if (((State == LiftState.GoUp || State == LiftState.GoDown) && value == LiftState.StayOpen) || 
                    (State == LiftState.StayOpen && (value == LiftState.GoUp || value == LiftState.GoDown))) { throw new ArgumentException(); }

                else {
                    State = value;
                }

            }
                }
    }
}
