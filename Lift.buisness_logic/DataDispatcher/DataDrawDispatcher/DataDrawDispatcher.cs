using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lift.Data;

namespace Lift.buisness_logic.DataDispatcher
{
    public struct DataForDraw
    {
        public readonly Point location;
        public readonly Size itemSize;
        public readonly int floorNumber;
        public DataForDraw(Point _location, Size _size, int _num)
        {
            location = _location;
            itemSize = _size;
            floorNumber = _num;

        }
    }

    public class DataDrawDispatcher
    {
        public DataForDraw _data;

        /*public DataDrawDispatcher(int itemN = 0, int floorN = 0)
        {
            var data = new DrawingData(itemN, floorN);
            _data = new DataForDraw(data.Location, data.itemSize, data.FloorNumber);
        }*/

        public void SetData(int itemN = 0, int floorN = 0)
        {
            var data = new DrawingData(itemN, floorN);
            _data = new DataForDraw(data.Location, data.itemSize, data.FloorNumber);
        }

    }
}
