namespace TrafficLight
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RedSec1 = new System.Windows.Forms.TextBox();
            this.OrangeSec1 = new System.Windows.Forms.TextBox();
            this.GreenSec1 = new System.Windows.Forms.TextBox();
            this.RedSec2 = new System.Windows.Forms.TextBox();
            this.OrangeSec2 = new System.Windows.Forms.TextBox();
            this.GreenSec2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timercars = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.Red1 = new System.Windows.Forms.PictureBox();
            this.Green1 = new System.Windows.Forms.PictureBox();
            this.Orange1 = new System.Windows.Forms.PictureBox();
            this.Green2 = new System.Windows.Forms.PictureBox();
            this.Orange2 = new System.Windows.Forms.PictureBox();
            this.Red2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Change!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(450, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Change!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.label1.Location = new System.Drawing.Point(12, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Time in Seconds  for Red:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.label2.Location = new System.Drawing.Point(12, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time in Seconds  for Orange:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.label3.Location = new System.Drawing.Point(12, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time in Seconds  for Green:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.label4.Location = new System.Drawing.Point(550, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Time in Seconds  for Red:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.label5.Location = new System.Drawing.Point(550, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Time in Seconds  for Orange:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.label6.Location = new System.Drawing.Point(550, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Time in Seconds  for Green:";
            // 
            // RedSec1
            // 
            this.RedSec1.Location = new System.Drawing.Point(180, 333);
            this.RedSec1.Name = "RedSec1";
            this.RedSec1.Size = new System.Drawing.Size(35, 20);
            this.RedSec1.TabIndex = 14;
            // 
            // OrangeSec1
            // 
            this.OrangeSec1.Location = new System.Drawing.Point(202, 366);
            this.OrangeSec1.Name = "OrangeSec1";
            this.OrangeSec1.Size = new System.Drawing.Size(35, 20);
            this.OrangeSec1.TabIndex = 15;
            // 
            // GreenSec1
            // 
            this.GreenSec1.Location = new System.Drawing.Point(192, 398);
            this.GreenSec1.Name = "GreenSec1";
            this.GreenSec1.Size = new System.Drawing.Size(35, 20);
            this.GreenSec1.TabIndex = 16;
            // 
            // RedSec2
            // 
            this.RedSec2.Location = new System.Drawing.Point(727, 27);
            this.RedSec2.Name = "RedSec2";
            this.RedSec2.Size = new System.Drawing.Size(35, 20);
            this.RedSec2.TabIndex = 17;
            // 
            // OrangeSec2
            // 
            this.OrangeSec2.Location = new System.Drawing.Point(740, 61);
            this.OrangeSec2.Name = "OrangeSec2";
            this.OrangeSec2.Size = new System.Drawing.Size(37, 20);
            this.OrangeSec2.TabIndex = 18;
            // 
            // GreenSec2
            // 
            this.GreenSec2.Location = new System.Drawing.Point(740, 96);
            this.GreenSec2.Name = "GreenSec2";
            this.GreenSec2.Size = new System.Drawing.Size(37, 20);
            this.GreenSec2.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.button3.Location = new System.Drawing.Point(513, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 45);
            this.button3.TabIndex = 20;
            this.button3.Text = "Auto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timercars
            // 
            this.timercars.Interval = 50;
            this.timercars.Tick += new System.EventHandler(this.timercars_Tick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.button4.Location = new System.Drawing.Point(513, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 45);
            this.button4.TabIndex = 25;
            this.button4.Text = "Stop Auto";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // Car2
            // 
            this.Car2.Image = global::TrafficLight.Properties.Resources.carcopy;
            this.Car2.Location = new System.Drawing.Point(372, 352);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(35, 66);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Car2.TabIndex = 24;
            this.Car2.TabStop = false;
            // 
            // Car1
            // 
            this.Car1.BackColor = System.Drawing.Color.Transparent;
            this.Car1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Car1.BackgroundImage")));
            this.Car1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Car1.Location = new System.Drawing.Point(582, 214);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(80, 30);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Car1.TabIndex = 23;
            this.Car1.TabStop = false;
            // 
            // Red1
            // 
            this.Red1.Image = global::TrafficLight.Properties.Resources.red;
            this.Red1.Location = new System.Drawing.Point(260, 261);
            this.Red1.Name = "Red1";
            this.Red1.Size = new System.Drawing.Size(76, 122);
            this.Red1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Red1.TabIndex = 0;
            this.Red1.TabStop = false;
            // 
            // Green1
            // 
            this.Green1.Image = global::TrafficLight.Properties.Resources.green;
            this.Green1.Location = new System.Drawing.Point(260, 261);
            this.Green1.Name = "Green1";
            this.Green1.Size = new System.Drawing.Size(76, 122);
            this.Green1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Green1.TabIndex = 3;
            this.Green1.TabStop = false;
            // 
            // Orange1
            // 
            this.Orange1.Image = global::TrafficLight.Properties.Resources.orange;
            this.Orange1.Location = new System.Drawing.Point(260, 261);
            this.Orange1.Name = "Orange1";
            this.Orange1.Size = new System.Drawing.Size(76, 122);
            this.Orange1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Orange1.TabIndex = 2;
            this.Orange1.TabStop = false;
            // 
            // Green2
            // 
            this.Green2.Image = global::TrafficLight.Properties.Resources.green;
            this.Green2.Location = new System.Drawing.Point(443, 25);
            this.Green2.Name = "Green2";
            this.Green2.Size = new System.Drawing.Size(82, 124);
            this.Green2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Green2.TabIndex = 5;
            this.Green2.TabStop = false;
            // 
            // Orange2
            // 
            this.Orange2.Image = global::TrafficLight.Properties.Resources.orange;
            this.Orange2.Location = new System.Drawing.Point(443, 25);
            this.Orange2.Name = "Orange2";
            this.Orange2.Size = new System.Drawing.Size(82, 124);
            this.Orange2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Orange2.TabIndex = 4;
            this.Orange2.TabStop = false;
            // 
            // Red2
            // 
            this.Red2.Image = global::TrafficLight.Properties.Resources.red;
            this.Red2.Location = new System.Drawing.Point(443, 24);
            this.Red2.Name = "Red2";
            this.Red2.Size = new System.Drawing.Size(82, 125);
            this.Red2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Red2.TabIndex = 1;
            this.Red2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Car2);
            this.Controls.Add(this.Car1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.GreenSec2);
            this.Controls.Add(this.OrangeSec2);
            this.Controls.Add(this.RedSec2);
            this.Controls.Add(this.GreenSec1);
            this.Controls.Add(this.OrangeSec1);
            this.Controls.Add(this.RedSec1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Red1);
            this.Controls.Add(this.Green1);
            this.Controls.Add(this.Orange1);
            this.Controls.Add(this.Green2);
            this.Controls.Add(this.Orange2);
            this.Controls.Add(this.Red2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Red1;
        private System.Windows.Forms.PictureBox Red2;
        private System.Windows.Forms.PictureBox Orange1;
        private System.Windows.Forms.PictureBox Green1;
        private System.Windows.Forms.PictureBox Orange2;
        private System.Windows.Forms.PictureBox Green2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RedSec1;
        private System.Windows.Forms.TextBox OrangeSec1;
        private System.Windows.Forms.TextBox GreenSec1;
        private System.Windows.Forms.TextBox RedSec2;
        private System.Windows.Forms.TextBox OrangeSec2;
        private System.Windows.Forms.TextBox GreenSec2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timercars;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
    }
}

