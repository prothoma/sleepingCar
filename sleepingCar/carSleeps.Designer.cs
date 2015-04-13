namespace sleepingCar
{
    partial class carSleep
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
            this.components = new System.ComponentModel.Container();
            this.drawInterval = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kmhourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kmhourToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kmhourToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawInterval
            // 
            this.drawInterval.Enabled = true;
            this.drawInterval.Tick += new System.EventHandler(this.drawInterval_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(316, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 90);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kmhourToolStripMenuItem,
            this.kmhourToolStripMenuItem1,
            this.kmhourToolStripMenuItem2});
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.speedToolStripMenuItem.Text = "Speed";
            // 
            // kmhourToolStripMenuItem
            // 
            this.kmhourToolStripMenuItem.Name = "kmhourToolStripMenuItem";
            this.kmhourToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.kmhourToolStripMenuItem.Text = "5 km/hour";
            this.kmhourToolStripMenuItem.Click += new System.EventHandler(this.kmhourToolStripMenuItem_Click);
            // 
            // kmhourToolStripMenuItem1
            // 
            this.kmhourToolStripMenuItem1.Name = "kmhourToolStripMenuItem1";
            this.kmhourToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.kmhourToolStripMenuItem1.Text = "10 km/hour";
            this.kmhourToolStripMenuItem1.Click += new System.EventHandler(this.kmhourToolStripMenuItem1_Click);
            // 
            // kmhourToolStripMenuItem2
            // 
            this.kmhourToolStripMenuItem2.Name = "kmhourToolStripMenuItem2";
            this.kmhourToolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.kmhourToolStripMenuItem2.Text = "20 km/hour";
            this.kmhourToolStripMenuItem2.Click += new System.EventHandler(this.kmhourToolStripMenuItem2_Click);
            // 
            // carSleep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "carSleep";
            this.Text = "RedCar";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.paintCar);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.carSleep_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer drawInterval;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kmhourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kmhourToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kmhourToolStripMenuItem2;

    }
}

