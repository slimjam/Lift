using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.buisness_logic
{
    enum LiftState
    {
        Go,
        StayClose,
        StayOpen
    }
    public class Lift : IModel
    {
        public readonly FloorButton[] buttons;
        public readonly GoButton goButton;
        public readonly int weidthLimit;
        public readonly int floorNumber = 0;
        public readonly WeidthController weidthController;
        // TODO valid mthod to managr
        private LiftState State {
            get
            {
                return this.State;
            }
            set
            {
                if ((this.State == LiftState.Go && value == LiftState.StayOpen) || 
                    (this.State == LiftState.StayOpen && value == LiftState.Go)) { throw new ArgumentException(); }

                else {
                    this.State = value;
                }

            }
                }
    }
}
