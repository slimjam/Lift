using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lift.Drawing;
using Lift.buisness_logic;
//using System.ComponentModel.DataAnnotations;

namespace Lift
{
    public partial class Form1 : Form
    {
        int ppl = 2; // test sheet
        public Painter painter;
        public buisness_logic.DataDispatcher.DataDrawDispatcher dataDrawDispatcher;

        public Form1()
        {
            InitializeComponent();
            painter = new Painter();
            dataDrawDispatcher = new buisness_logic.DataDispatcher.DataDrawDispatcher();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void config_panel()
        {

        }

        private void configButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var lab = new ListViewItem();
            lab.Text = "Config";
            listView1.Items.Add(lab);
            listView1.Visible = true;
        }

        private void pplInformButton_Click(object sender, EventArgs e)
        {
            //TODO start->simul->showInfo = noInfo; 
            listView1.Items.Clear();
            var lab = new ListViewItem();
            lab.Text = "Test Label for PPLINFO";
            listView1.Items.Add(lab);
            listView1.Visible = true;
        }

        private void simulationButton_Click(object sender, EventArgs e)
        {
            int floorsCount = 4; // test sheet
            // read from startupconf.floorsnum
            listView1.Visible = false;

            for (int n = 0; n < floorsCount; ++n)
            {
                dataDrawDispatcher.SetData(floorN: n);
                var data = dataDrawDispatcher._data;
                var lift = painter.drawLift(data);
                mainPanel.Controls.Add(lift);

            }
        }

        private void showButtons(List<Control.ControlCollection> collections)
        {
            foreach (var collection in collections)
            {
                foreach (Button button in collection)
                {
                    button.Visible = true;
                }
            }
        }

        private bool hideStartUpPanel()
        {
            // check req fields
            // notificate if they r empty
            bool res = true;

            if(numericFloors.Value <= 0 && numericFloors.Value <= 5)
            {
                numericFloors.BackColor = Color.LightPink; // looks like constant
                labelFloorError.Visible = true;
                res = false;
            }
            else // mb add if() is it changed..
            {
                numericFloors.BackColor = Color.White;
                labelFloorError.Visible = false;
            }

            if (numericPpl.Value <= 0)
            {
                numericPpl.BackColor = Color.LightPink;
                labelPplError.Visible = true;
                res = false;
            }
            else
            {
                numericPpl.BackColor = Color.White;
                labelPplError.Visible = false;
            }

            if (res) { startUpPanel.Visible = false; }
            return res;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!hideStartUpPanel()) { return; }

            var collections = new List<Control.ControlCollection>();
            collections.Add(panel2.Controls);
            collections.Add(panel4.Controls);
            showButtons(collections);
            
            startButton.Visible = false;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            //make visible startup panel mb?
            //if yes, check that error labels are invisible

            //test sheet
            foreach (Control control in mainPanel.Controls)
            {
                if(control.GetType() == typeof(LiftPrototype))
                {
                    var lift = (LiftPrototype)control;
                    lift.Full();
                }
                
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            dataDrawDispatcher.SetData(itemN:ppl); //test sheet
            var data = dataDrawDispatcher._data;
            var man = painter.drawMan(data);
            mainPanel.Controls.Add(man);
            ppl += 1;
        }
        // add validation for draw.location and form.size 
                
    }
}
