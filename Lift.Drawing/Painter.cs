using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lift.Data;
using Lift.buisness_logic.DataDispatcher;

namespace Lift.Drawing
{
    public class LiftPrototype : Button
    {
        private Color empty = Color.WhiteSmoke;
        private Color full = Color.Beige;
        public LiftPrototype(DataForDraw data)
        {
            Enabled = false;
            Location = data.location;
            Name = "flor" + data.floorNumber.ToString();
            Size = data.itemSize;
            UseVisualStyleBackColor = true;
            BackColor = empty;
        }

        public void Full()
        {
            BackColor = full;
        }

        public void Empty()
        {
            BackColor = empty;
        }

    }

    public class Painter
    {
        public PictureBox drawMan(DataForDraw data)
        {
            var pb = new PictureBox();
            pb.Image = new Bitmap(Properties.Resources.standing_man5050);
            pb.Size = data.itemSize;
            pb.Location = data.location;
            pb.Enabled = false;
            pb.BorderStyle = BorderStyle.None;
            pb.BackColor = Color.Transparent;
            return pb;
        }

        public void drawBuilding(Panel panel)
        {
            panel.BackgroundImage = new Bitmap(Properties.Resources.Buiding);
            panel.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public LiftPrototype drawLift(DataForDraw data) => new LiftPrototype(data);

        public void emptyLift(LiftPrototype lift)
        {
            lift.Empty(); 
        }

        public void fullLift(LiftPrototype lift)
        {
            lift.Full();
        }
    }
}
