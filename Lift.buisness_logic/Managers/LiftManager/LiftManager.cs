using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.buisness_logic
{
    public class LiftManager : BaseManager
    {
        private bool IsFloorButtonPressed(int floorNum)
        {
            // bad way.. better create some util or 'response' to main manager. Not direct usage. But deadlines..
            mainManager.buttonManager.GetButtonState(floorNum);
            return mainManager.floorManager.GetButtonState(floorNum);
        }
        public void Main()
        {
            while (true)
            {
                // dekompose lift methods and all other to allot mthds and controllers will call it!
                foreach (IModel _lift in items) // in current realese it will be always just one lift
                {
                    Lift lift = _lift as Lift;
                    if (IsFloorButtonPressed(lift.floorNumber))
                    {
                        if (lift.State == LiftState.GoUp || lift.State == LiftState.GoDown)
                        {
                            lift.State = LiftState.StayClose;
                        }
                        if (lift.State == LiftState.StayClose)
                        {
                            lift.State = LiftState.StayOpen;    //refactor to if !open : =open
                        }
                        //ppl into
                        // and out!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                        mainManager.humanManager.TellPplToEnterLift(lift.floorNumber);
                        var weidth = mainManager.humanManager.GetPplSumWeidth(lift.humen);
                        while (lift.weidthController.IsOverload(weidth))
                        {
                            mainManager.humanManager.TellLastHumanToLeaveLift();
                            // check the method in if how much times is calling
                        }
                        if (!IsGoButtonPressed(lift))   //if not a cicle mb just delete this if but save the body? because we check state in method
                        {
                            WaitForGoButton(lift);
                        }
                        else
                        {
                            lift.State = LiftState.StayClose;
                            // refactor to while cicle or mb sleep thread..
                        }
                    }
                    else
                    {
                        if (lift.State != LiftState.GoUp || lift.State != LiftState.GoDown)     // add []GoState
                        {
                            if (!IsActiveAnyButtons())
                            {
                                WaitForAnyButton();
                            }
                            lift.State = mainManager.buttonManager.GetDirection(lift.floorNumber);
                        } 
                    }
                    Go(lift);
                }
            }
        }

        private void WaitForAnyButton()
        {
            if (!IsActiveAnyButtons())
            {
                WaitForAnyButton();
            }
        }

        private bool IsActiveAnyButtons()
        {
            return mainManager.buttonManager.IsActiveAnyButtons();
        }

        private void Go(Lift lift)
        {
            if (lift.State == LiftState.GoDown)
            {
                lift.floorNumber -= 1;  // make floorNumber as a properties, and check valid
            }
            if (lift.State == LiftState.GoUp)
            {
                lift.floorNumber += 1;
            }
        }

        public void WaitForGoButton(Lift lift)
        {
            if (!IsGoButtonPressed(lift))
            {
                // wait
                WaitForGoButton(lift);
            }
        }

        public bool IsGoButtonPressed(Lift lift)
        {
            return lift.goButton.IsPressed;
        }
        public override IModel CreateItem()
        {
            var lift = new Lift();
            AddItem(lift);
            return lift;
        }
    }
}
