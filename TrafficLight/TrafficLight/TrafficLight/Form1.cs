using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //BUTTON CHANGE1,Αλλαγή των φαναρίων με το κουμπί 1
        {
            timer4.Enabled = true;
            if ((Red1.Visible=true) && (Orange2.Visible=true))
            {
                Red1.Visible = false;
                Orange1.Visible = false;
                Green1.Visible = true;//Αρχικά ανάβει το πράσινο, με τα πάτημα του κουμπιού
                Red2.Visible = true;//Σύμφωνα με τον κανόνα ανάβει το κόκκινο του άλλου φαναριού
                Orange2.Visible = false;
                Green2.Visible = false;
            }
            else if ((Red1.Visible=true) && (Green2.Visible=true))
            {
                Red1.Visible = true;
                Orange1.Visible = false;
                Green1.Visible = false;
                Red2.Visible = false;
                Orange2.Visible = true;
                Green2.Visible = false;
            }
            else if (Orange1.Visible=true)
            {
                Red1.Visible = true;
                Orange1.Visible = false;
                Green1.Visible = false;
                Red2.Visible = false;
                Orange2.Visible = false;
                Green2.Visible = true;
            }
            else if (Green1.Visible=true)
            {
                Red1.Visible = false;
                Orange1.Visible = true;
                Green1.Visible = false;
                Red2.Visible = true;
                Orange2.Visible = false;
                Green2.Visible = false;
            }
        }
        private void timer4_Tick(object sender, EventArgs e)// Stop Car2 όταν κόκκινο
        {
            timer4.Interval = 500;
            if ((Car2.Top + Car2.Size.Height / 3 >= Red1.Top) && (Car2.Top <= Red1.Top + Red1.Size.Height) && (Red1.Visible))
            {
                Car2.Top = Car2.Top;
            }
            else
            {
                Car2.Top = Car2.Top -= 10;
            }
        }

        private int trafficcolour = 0;
        int a, b, c, d, k, f = 0;
        private void timercars_Tick(object sender, EventArgs e)//
        {
            timercars.Enabled = true;

            if (Car1.Left + Car1.Size.Width <= 0) //Τοποθέτηση αυτοκινήτων στισ αρχικές θέσεις.
            {
                Car1.Left = 700;
            }
            if (Car2.Top + Car2.Size.Height <= 0)
            {
                Car2.Top = 500;
            }

            a = Convert.ToInt32(RedSec1.Text);
            b = Convert.ToInt32(GreenSec1.Text);
            c = Convert.ToInt32(OrangeSec1.Text);
            d = Convert.ToInt32(RedSec2.Text);
            k = Convert.ToInt32(GreenSec2.Text);
            f = Convert.ToInt32(OrangeSec2.Text);
            if (!(String.IsNullOrEmpty(RedSec1.Text)) & (a > 0) & !(String.IsNullOrEmpty(GreenSec1.Text)) & (b > 0) & !(String.IsNullOrEmpty(OrangeSec1.Text)) & (c > 0) & !(String.IsNullOrEmpty(RedSec2.Text)) & (d > 0) & !(String.IsNullOrEmpty(GreenSec2.Text)) & (k > 0) & !(String.IsNullOrEmpty(OrangeSec2.Text)) & (f > 0)) {

                trafficcolour = trafficcolour % 4;//Παίρνω περιπτώσεις,αρχικά όταν είναι ανοιχτό το κόκκινο από το πρώτο φανάρι,ανάβει το πράσινο στο πρώτο και το κόκκινο στο δεύτερο φανάρι και το timer παίρνει το χρόνο που θα παραμείνει το πράσινο.Παρομοίως για το υπόλοιπα. 
                switch (trafficcolour)
                {
                    case 0:
                        timercars.Interval = a * 1000;
                        Red2.Visible = false;
                        Green2.Visible = true;
                        Orange2.Visible = false;
                        Red1.Visible = true;
                        Green1.Visible = false;
                        Orange1.Visible = false;
                        break;
                    case 1:
                        timercars.Interval = f * 1000;
                        Red2.Visible = false;
                        Green2.Visible = false;
                        Orange2.Visible = true;
                        Red1.Visible = true;
                        Green1.Visible = false;
                        Orange1.Visible = false;
                        break;
                    case 2:
                        timercars.Interval = b * 1000;
                        Green2.Visible = false;
                        Orange2.Visible = false;
                        Red2.Visible = true;
                        Green1.Visible = true;
                        Orange1.Visible = false;
                        Red1.Visible = false;
                        break;
                    case 3:
                        timercars.Interval = c * 1000;
                        Green2.Visible = false;
                        Orange2.Visible = false;
                        Red2.Visible = true;
                        Green1.Visible = false;
                        Orange1.Visible = true;
                        Red1.Visible = false;
                        break;
                }
                trafficcolour++;

            }

        }
   

        private void timer2_Tick(object sender, EventArgs e)//Ελέγχω πότε φτάνουν στα φανάρια προκειμένου να σταματήσουν τα αυτοκίνητα.
        {
            if ((((Car2.Top + Car2.Size.Height) > (Red1.Top)) && (Car2.Top < Red2.Top) && (Car1.Left < Red2.Left) && (Car1.Left + Car1.Size.Width) > (Red1.Left)) || (((Car2.Top + Car2.Size.Height) > (Red1.Top)) && (Car2.Top < Red2.Top)))
            {
                timercars.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
            }
            else
            {

                if ((Car1.Left > Red2.Left) && (Car1.Left < Red2.Left + Red2.Size.Width) && (Red2.Visible))
                {
                    Car1.Left = Car1.Left;
                }
                else
                {
                    Car1.Left = Car1.Left -= 10;
                }

                if ((Car2.Top + Car2.Size.Height / 3 >= Red1.Top) && (Car2.Top <= Red1.Top + Red1.Size.Height) && (Red1.Visible))
                {
                    Car2.Top = Car2.Top;
                }
                else
                {
                    Car2.Top = Car2.Top -= 10;
                }
                if ((Car1.Left > Red2.Left) && (Car1.Left < Red2.Left + Red2.Size.Width) && (Red2.Visible))
                {
                    Car1.Left = Car1.Left;
                }
                else
                {
                    Car1.Left = Car1.Left -= 10;
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)//Επιτάχυνση ταχύτητας του Car1 όταν ξεπεράσει το φανάρι.
        {
            if (Car1.Left < Red2.Left)
            {
                Car1.Left -= 30;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)//Επιτάχυνση ταχύτητας του Car2 όταν ξεπεράσει το φανάρι.
        {
            if (Car2.Top < Red1.Top)
            {
                Car2.Top -= 30;
            }
        }

        private void button2_Click(object sender, EventArgs e)  //BUTTON CHANGE2 , ίδια διαδικασία με το CHANGE1, με τις κατάλληλες τροπόποιήσεις.
        {
            timer3.Enabled = true;
            if ((Red2.Visible) && (Orange1.Visible))
            {
                Red2.Visible = false;
                Orange2.Visible = false;
                Green2.Visible = true;
                Red1.Visible = true;
                Orange1.Visible = false;
                Green1.Visible = false;
            }
            else if ((Red2.Visible) && (Green1.Visible))
            {
                Red2.Visible = true;
                Orange2.Visible = false;
                Green2.Visible = false;
                Red1.Visible = false;
                Orange1.Visible = true;
                Green1.Visible = false;
            }
            else if (Orange2.Visible)
            {
                Red2.Visible = true;
                Orange2.Visible = false;
                Green2.Visible = false;
                Red1.Visible = false;
                Orange1.Visible = false;
                Green1.Visible = true;
            }
            else if (Green2.Visible)
            {
                Red2.Visible = false;
                Orange2.Visible = true;
                Green2.Visible = false;
                Red1.Visible = true;
                Orange1.Visible = false;
                Green1.Visible = false;
            }


        }
        private void timer3_Tick(object sender, EventArgs e)// Stop Car1 όταν φανάρι κόκκινο.
        {
            timer3.Interval = 500;

            if ((Car1.Left > Red2.Left) && (Car1.Left < Red2.Left + Red2.Size.Width) && (Red2.Visible))
            {
                Car1.Left = Car1.Left;
            }
            else
            {
                Car1.Left = Car1.Left -= 10;
            }
        }

        private void button3_Click(object sender, EventArgs e)// AUTO. Πραγματοποιώ έλεγχο των textboxes και αν τον ικανοποιούν ενεργοποιώ τα timer.
        {
            a = Convert.ToInt32(RedSec1.Text);
            b = Convert.ToInt32(GreenSec1.Text);
            c = Convert.ToInt32(OrangeSec1.Text);
            d = Convert.ToInt32(RedSec2.Text);
            k = Convert.ToInt32(GreenSec2.Text);
            f = Convert.ToInt32(OrangeSec2.Text);
            if ( (!(String.IsNullOrEmpty(RedSec1.Text))) & (a > 0)  &   (!(String.IsNullOrEmpty(GreenSec1.Text))) & (b > 0) & (!(String.IsNullOrEmpty(OrangeSec1.Text))) & (c > 0) & (!(String.IsNullOrEmpty(RedSec2.Text))) & (d > 0) & (!(String.IsNullOrEmpty(GreenSec2.Text))) & (k > 0) & (!(String.IsNullOrEmpty(OrangeSec2.Text))) & (f > 0))
            {
                timercars.Enabled = true;
                timer2.Enabled = true;
                timer4.Enabled = true;
                timer3.Enabled = true;
                timer5.Enabled = true;
                timer6.Enabled = true;
                if (Car1.Location.X == 100)
                {
                    Car1.Location = new Point(582, 214);
                }
                if (Car2.Location.Y == 40)
                {
                    Car2.Location = new Point(372, 352);
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Το TrafficLight είναι μια παραθυρική εφαρμογή,στην οποία <<συγχρονίζονται>> τα διασταυρόμενα φανάρια με σκοπό να <<υπακούν>> τους κανόνες των φαναριών.","About");
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)//Αρχικοποίηση της φόρμας
        {
            RedSec1.Clear();//Αρχικοποίηση των textbox
            OrangeSec1.Clear();
            GreenSec1.Clear();
            RedSec2.Clear();
            OrangeSec2.Clear();
            GreenSec2.Clear();
            Car1.Location = new Point(582, 214);//Αρχικοπόίηση θέσεων των picturebox
            Car2.Location = new Point(372, 352);
            Red1.Visible = true;
            Orange1.Visible = false;
            Green1.Visible = false;
            Red2.Visible = true;
            Orange2.Visible = false;
            Green2.Visible = false;
            timercars.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
        }

       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.Black, 10);
            Pen p1 = new Pen(Color.Gray, 3);
            l.DrawLine(p1, 425, 210, 500, 210);
            l.DrawLine(p1, 425, 220, 500, 220);
            l.DrawLine(p1, 425, 230, 500, 230);
            l.DrawLine(p1, 425, 240, 500, 240);

            l.DrawLine(p1, 280, 210, 355, 210);//Διάβαση
            l.DrawLine(p1, 280, 220, 355, 220);
            l.DrawLine(p1, 280, 230, 355, 230);
            l.DrawLine(p1, 280, 240, 355, 240);

            l.DrawLine(p, 10, 250, 355, 250);//Δημιουργία ευθειών 
            l.DrawLine(p, 10, 200, 355, 200);
            l.DrawLine(p, 365, 5, 365, 175);
            l.DrawLine(p, 415, 5, 415, 175);
            l.DrawLine(p, 425, 200, 745, 200);
            l.DrawLine(p, 425, 250, 745, 250);
            l.DrawLine(p, 415, 270, 415, 440);
            l.DrawLine(p, 365, 270, 365, 440);
            l.Dispose();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Συγχρονισμός διασταυρούμενων φαναριών και προσομοίωση κίνησης αυτοκινήτων.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)//Stop Auto
        {
           
            RedSec1.Clear();//Αρχικοποίηση των textbox
            OrangeSec1.Clear();
            GreenSec1.Clear();
            RedSec2.Clear();
            OrangeSec2.Clear();
            GreenSec2.Clear();
            Car1.Location = new Point(582, 214);//Αρχικοπόίηση θέσεων των picturebox
            Car2.Location = new Point(372, 352);
            Red1.Visible = true;
            Orange1.Visible = false;
            Green1.Visible = false;
            Red2.Visible = true;
            Orange2.Visible = false;
            Green2.Visible = false;
            timercars.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;

        }
    }
}
