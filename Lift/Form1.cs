using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            listView1.Items.Clear();
            //dataGridView1.DataSource = null;

            //List<object> items = new List<object>();
            var lab = new ListViewItem();
            lab.Text = "Test Label for PPLINFO";
            //items.Add(lab);
            listView1.Items.Add(lab);
            //DataGridViewElement
            //listView1.
            //dataGridView1.DataSource = items;
            listView1.Visible = true;
        }

        private void simulationButton_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            var flor = new Button();
            flor.Enabled = false;
            flor.Location = new Point(130, 20);
            flor.Name = "flor1";
            flor.Size = new Size(50, 50);
            flor.UseVisualStyleBackColor = true;
            flor.BackColor = Color.Red;
            mainPanel.Controls.Add(flor);

            var flor2 = new Button();
            flor2.Enabled = false;
            flor2.Location = new Point(130, 70);
            flor2.Name = "flor1";
            flor2.Size = new Size(50, 50);
            flor2.UseVisualStyleBackColor = true;
            flor2.BackColor = Color.Red;
            mainPanel.Controls.Add(flor2);
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {

        }

    }
}
