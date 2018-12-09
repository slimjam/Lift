using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.Data
{
    public class DrawingData
    {
        private Point startLocation = new Point(100, 20);
        public readonly Size itemSize = new Size(50,50);
        public Point Location
        {
            get
            {
                return new Point(startLocation.X + (itemSize.Width * (itemNumber-1)), startLocation.Y + (itemSize.Width * (FloorNumber)));   //itemNumber-1
            }
        } // calculated on start location and itemnuber
        private int itemNumber;
        public readonly int FloorNumber;
        public DrawingData(int itemN = 0, int floorN = 0)
        {
            itemNumber = itemN;
            FloorNumber = floorN;
        }
    }
}
