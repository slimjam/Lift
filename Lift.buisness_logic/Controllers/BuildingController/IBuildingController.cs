using Lift.buisness_logic.Models.Building;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.buisness_logic.Controllers.BuildingController
{
    interface IBuildingController
    {
        void AddBuilding(Building building);
        void RemoveBuilding(Building building);
        Building CreateBuilding();
        void DeleteBuilding(Building building);
    }
}
