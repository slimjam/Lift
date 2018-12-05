﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.buisness_logic.Models.Lift
{
    enum LiftState
    {
        Go,
        StayClose,
        StayOpen
    }
    class Lift
    {
        public readonly Button.FloorButton buttons;
        public readonly Button.GoButton goButton;
        public readonly int weidthLimit;
        public readonly Controllers.WeidthController.Implementations.WeidthController weidthController;
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