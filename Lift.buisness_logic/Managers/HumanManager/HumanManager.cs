using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.buisness_logic
{
    public class HumanManager : BaseManager
    {
        public void TellPplToEnterLift(int floorNumber)
        {
            //move ppl from floor list to lift list
        }

        public int GetPplSumWeidth(List<Human> humen)
        {
            int summaryWeidth = 0;
            foreach (Human human in humen) {summaryWeidth += human.weidth;};
            return summaryWeidth;
        }

        internal void TellLastHumanToLeaveLift()
        {
            var lift = mainManager.liftManager.items[0] as Lift;    // not direct make get method
            var human = lift.humen.Last();  //check if it delete it like a pop
            mainManager.floorManager.AddHumanToFloor(human, lift.floorNumber);
        }
    }
}
