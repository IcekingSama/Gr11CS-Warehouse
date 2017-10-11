/*
 * Edward Wan
 * Oct.3 2017
 * This Program is create a automated warehouse to test the spring's potential energy
 * and box's kinetic energy， to see how far the box can go and reaching the robot
 **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdwardWanA1Warehouse
{
    public partial class Form1 : Form
    {
        //declare the spring contstant
        int SpringConstant = 18000;
        // declare all the x and y for box, spring, and blitz
        int BoxX, BoxY = 300, SpringX, SpringY , BlitzX, BlitzY;
        //declare the spring distance, box mass as 1, time as 0 and the time that box gonna stop, and moving distance
        double counter, SpringDistance, BoxMass = 1, Time = 0, StoppingTime, StartingSpeed, MovingDistance;
        public Form1()
        {
            InitializeComponent();
            //Make the program listen the keyboard
            KeyPreview = true;
            tmrTime.Enabled = false;
        }

        void Maths()
        {
            //Calcualte Starting speed since potential energy is equal to kenetic energy
            //PE = KE, 1/2 cancelled out each other, whats left is v^2 * m = k * x^2
            //Which is v^2 = x^2 *k *m
            //(starting speed)v = sqrt(x^2 * k * m)
            StartingSpeed = Math.Sqrt((Math.Pow(SpringDistance, 2) * SpringConstant) / BoxMass);
            //The time when the box is stop v2 = v1 + a * t
            StoppingTime = StartingSpeed / (2.94 * BoxMass);
            //This is the equation that box move, d = v1 * t + 1/2 * a * t 
            MovingDistance = StartingSpeed * Time + (-2.94 * BoxMass) * Math.Pow(Time, 2) / 2;
            lblMovingDistance.Text = "Box moves Distance: " + MovingDistance.ToString();
            lblStoppingTime.Text = "Stopping Time: " + StoppingTime.ToString();
            lblStartingSpeed.Text = "Starting Speed: " + StartingSpeed.ToString();
        }

        void BoxLocation()
        {
            //Make the box follow the spring
            BoxX = picSpring.Left + picSpring.Width;
            SpringY = BoxY;
            picBox.Location = new Point((int)BoxX, (int)BoxY);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            { //Box heavier
                BoxMass += 0.1;
                picBox.Width += (int)BoxMass;
                picBox.Height += (int)BoxMass;
                if (BoxMass <= 1)
                {
                    BoxMass = 1;
                }
                lblBoxMass.Text = "Mass value: " + BoxMass.ToString();
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            { //Box Lighter
                BoxMass -= 0.1;
                picBox.Width -= (int)BoxMass;
                picBox.Height -= (int)BoxMass;
                if (BoxMass <= 1)
                {
                    BoxMass = 1; 
                }
                lblBoxMass.Text = "Box Mass: " + BoxMass.ToString();
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            { //Spring Compression
                SpringDistance -= 0.01;
                picSpring.Width += (int)SpringDistance * 10;
                if (SpringDistance <= 0)
                {
                    SpringDistance = 0;
                }
                lblSpringDistance.Text = "Spring Distance: " + SpringDistance.ToString();
                BoxLocation();
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            { //Spring Stertch
                SpringDistance += 0.01;
                //Make the spring image become bigger
                picSpring.Width -= (int)SpringDistance * 10;
                if (SpringDistance <= 0)
                {
                    SpringDistance = 0;
                }

                lblSpringDistance.Text = "Spring Distance: " + SpringDistance.ToString();
                BoxLocation();
            }

            if (e.KeyCode == Keys.Back)
            {
                Application.Restart();
            }

            if (e.KeyCode == Keys.Enter)
            {
                tmrTime.Enabled = true;
                Maths();
            }
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            counter += 0.1;
            Maths();
            if (counter <= StoppingTime)
            {
                BoxX = BoxX + (int)MovingDistance;
                picBox.Location = new Point(BoxX, BoxY);
            }
            else
            {
                tmrTime.Enabled = false;
            }
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
