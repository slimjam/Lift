using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.buisness_logic
{
    public class SystemManager
    {
        public LiftManager liftManager;
        public BuildingManager buildingManager;
        public ButtonManager buttonManager;
        public FloorManager floorManager;
        public HumanManager humanManager;

        SystemManager(LiftManager _liftManager, ButtonManager _buttonManager,
            BuildingManager _buildingManager, FloorManager _floorManager, HumanManager _humanManager)
        {
            liftManager = _liftManager;
            buildingManager = _buildingManager;
            buttonManager = _buttonManager;
            floorManager = _floorManager;
            humanManager = _humanManager;
        }
        //(not create (controllers create) ,just main) all managers
        // systemmanager is created by systemcontroller. References from other managers to its constructor 
        // systemmanager get from systemcontroller. systemcontroller get it from other *parents controllers.
    }
}
