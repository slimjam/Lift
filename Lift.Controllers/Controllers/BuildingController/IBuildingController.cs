using Lift.buisness_logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.Controllers
{
    interface IBuildingController
    {
        void AddBuilding(Building building);
        void RemoveBuilding(Building building);
        Building CreateBuilding();
        void DeleteBuilding(Building building);
    }
}
