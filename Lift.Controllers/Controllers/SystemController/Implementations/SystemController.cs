using System;
using Lift.buisness_logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.Controllers
{
    public class SystemController
    {
        private BuildingController buildingController;
        private FloorController floorController;
        private LiftController liftController;
        private ButtonController buttonController;
        private HumanController humanController;
        private SystemManager manager;

        SystemController()
        {
            buildingController = new BuildingController();
            floorController = new FloorController();
            liftController = new LiftController();
            buttonController = new ButtonController();
            humanController = new HumanController();
            manager = new SystemManager(liftController.manager, buttonController.manager,
            buildingController.manager, floorController.manager, humanController.manager);
        }
        public void Run()
        {
            liftController.manager.CreateItem();
            var lift = liftController.manager.items[0];
            if (buttonController.manager. IsFloorButtonPressed(lift.floorNumber))
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
    }
}
