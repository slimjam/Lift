namespace Lift
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.createButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.configButton = new System.Windows.Forms.Button();
            this.pplInformButton = new System.Windows.Forms.Button();
            this.simulationButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.startUpPanel = new System.Windows.Forms.Panel();
            this.labelPplError = new System.Windows.Forms.Label();
            this.labelFloorError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericPpl = new System.Windows.Forms.NumericUpDown();
            this.numericFloors = new System.Windows.Forms.NumericUpDown();
            this.checkBoxDisplay = new System.Windows.Forms.CheckBox();
            this.checkBoxExcel = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.startUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFloors)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(70)))), ((int)(((byte)(107)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 545);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 67);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.createButton);
            this.panel2.Controls.Add(this.stopButton);
            this.panel2.Controls.Add(this.startButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 478);
            this.panel2.TabIndex = 1;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(70)))));
            this.createButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.createButton.Location = new System.Drawing.Point(0, 142);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(168, 71);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "CREATE MAN";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Visible = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(34)))), ((int)(((byte)(70)))));
            this.stopButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.stopButton.Location = new System.Drawing.Point(0, 71);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(168, 71);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "STOP SIMULATION";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(70)))));
            this.startButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.startButton.Location = new System.Drawing.Point(0, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(168, 71);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START SIMULATION";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.panel4.Controls.Add(this.configButton);
            this.panel4.Controls.Add(this.pplInformButton);
            this.panel4.Controls.Add(this.simulationButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(168, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(851, 68);
            this.panel4.TabIndex = 1;
            // 
            // configButton
            // 
            this.configButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.configButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.configButton.FlatAppearance.BorderSize = 0;
            this.configButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.configButton.Location = new System.Drawing.Point(565, 0);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(286, 68);
            this.configButton.TabIndex = 3;
            this.configButton.Text = "CONFIGURATION";
            this.configButton.UseVisualStyleBackColor = false;
            this.configButton.Visible = false;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // pplInformButton
            // 
            this.pplInformButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.pplInformButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pplInformButton.FlatAppearance.BorderSize = 0;
            this.pplInformButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pplInformButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pplInformButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.pplInformButton.Location = new System.Drawing.Point(287, 0);
            this.pplInformButton.Name = "pplInformButton";
            this.pplInformButton.Size = new System.Drawing.Size(278, 68);
            this.pplInformButton.TabIndex = 2;
            this.pplInformButton.Text = "PEOPLE INFORMATION";
            this.pplInformButton.UseVisualStyleBackColor = false;
            this.pplInformButton.Visible = false;
            this.pplInformButton.Click += new System.EventHandler(this.pplInformButton_Click);
            // 
            // simulationButton
            // 
            this.simulationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.simulationButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.simulationButton.FlatAppearance.BorderSize = 0;
            this.simulationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simulationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simulationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.simulationButton.Location = new System.Drawing.Point(0, 0);
            this.simulationButton.Name = "simulationButton";
            this.simulationButton.Size = new System.Drawing.Size(287, 68);
            this.simulationButton.TabIndex = 1;
            this.simulationButton.Text = "SIMULATION";
            this.simulationButton.UseVisualStyleBackColor = false;
            this.simulationButton.Visible = false;
            this.simulationButton.Click += new System.EventHandler(this.simulationButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.mainPanel.Controls.Add(this.startUpPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanel.Location = new System.Drawing.Point(168, 68);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(851, 477);
            this.mainPanel.TabIndex = 2;
            // 
            // startUpPanel
            // 
            this.startUpPanel.Controls.Add(this.labelPplError);
            this.startUpPanel.Controls.Add(this.labelFloorError);
            this.startUpPanel.Controls.Add(this.label2);
            this.startUpPanel.Controls.Add(this.label1);
            this.startUpPanel.Controls.Add(this.numericPpl);
            this.startUpPanel.Controls.Add(this.numericFloors);
            this.startUpPanel.Controls.Add(this.checkBoxDisplay);
            this.startUpPanel.Controls.Add(this.checkBoxExcel);
            this.startUpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startUpPanel.Location = new System.Drawing.Point(0, 0);
            this.startUpPanel.Name = "startUpPanel";
            this.startUpPanel.Size = new System.Drawing.Size(851, 477);
            this.startUpPanel.TabIndex = 0;
            // 
            // labelPplError
            // 
            this.labelPplError.AutoSize = true;
            this.labelPplError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPplError.ForeColor = System.Drawing.Color.Crimson;
            this.labelPplError.Location = new System.Drawing.Point(467, 50);
            this.labelPplError.Name = "labelPplError";
            this.labelPplError.Size = new System.Drawing.Size(295, 20);
            this.labelPplError.TabIndex = 7;
            this.labelPplError.Text = "People quantity should be greater then 0";
            this.labelPplError.Visible = false;
            // 
            // labelFloorError
            // 
            this.labelFloorError.AutoSize = true;
            this.labelFloorError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFloorError.ForeColor = System.Drawing.Color.Crimson;
            this.labelFloorError.Location = new System.Drawing.Point(467, 12);
            this.labelFloorError.Name = "labelFloorError";
            this.labelFloorError.Size = new System.Drawing.Size(381, 20);
            this.labelFloorError.TabIndex = 6;
            this.labelFloorError.Text = "Floors quantity should be in rang from 1 to 5 included";
            this.labelFloorError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please, enter people quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please, enter floors quantity";
            // 
            // numericPpl
            // 
            this.numericPpl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericPpl.Location = new System.Drawing.Point(350, 48);
            this.numericPpl.Name = "numericPpl";
            this.numericPpl.Size = new System.Drawing.Size(104, 22);
            this.numericPpl.TabIndex = 3;
            // 
            // numericFloors
            // 
            this.numericFloors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericFloors.Location = new System.Drawing.Point(350, 6);
            this.numericFloors.Name = "numericFloors";
            this.numericFloors.Size = new System.Drawing.Size(104, 22);
            this.numericFloors.TabIndex = 2;
            // 
            // checkBoxDisplay
            // 
            this.checkBoxDisplay.AutoSize = true;
            this.checkBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDisplay.Location = new System.Drawing.Point(24, 301);
            this.checkBoxDisplay.Name = "checkBoxDisplay";
            this.checkBoxDisplay.Size = new System.Drawing.Size(709, 33);
            this.checkBoxDisplay.TabIndex = 1;
            this.checkBoxDisplay.Text = "Show information on the screen after programm shutdown";
            this.checkBoxDisplay.UseVisualStyleBackColor = true;
            // 
            // checkBoxExcel
            // 
            this.checkBoxExcel.AutoSize = true;
            this.checkBoxExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExcel.Location = new System.Drawing.Point(24, 356);
            this.checkBoxExcel.Name = "checkBoxExcel";
            this.checkBoxExcel.Size = new System.Drawing.Size(704, 33);
            this.checkBoxExcel.TabIndex = 0;
            this.checkBoxExcel.Text = "Write information into Excel file after programm shutdown";
            this.checkBoxExcel.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LavenderBlush;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.Location = new System.Drawing.Point(755, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(264, 477);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 545);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lift";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.startUpPanel.ResumeLayout(false);
            this.startUpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFloors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Button pplInformButton;
        private System.Windows.Forms.Button simulationButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel startUpPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericPpl;
        private System.Windows.Forms.NumericUpDown numericFloors;
        private System.Windows.Forms.CheckBox checkBoxDisplay;
        private System.Windows.Forms.CheckBox checkBoxExcel;
        private System.Windows.Forms.Label labelPplError;
        private System.Windows.Forms.Label labelFloorError;
    }
}

