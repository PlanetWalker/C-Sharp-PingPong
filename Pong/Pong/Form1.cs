using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        class GameManager
        {
            private static int speed = 3;
            private static int sliderSpeed = 5;

            private int intFail = 0;

            private int points = 0;
            public GameManager()
            {

            }

            public void ResetAll()
            {
                ResetSpeed();
            }

            public void ResetSpeed()
            {
                speed = 3;
                sliderSpeed = 5;
            }

        }
        GameManager gm = new GameManager();

        public Form1()
        {
            InitializeComponent();

            gm.ResetSpeed();

            speed = 3;
            sliderSpeed = 5;
            pictureBox3.Visible = info.Visible = false;

            Horzontal.Enabled = Vertikal.Enabled = false;
            Ball.Location = new Point(12, 12);

            info.Text = "Drücke die space Taste um zu Starten!";
            info.Visible = boolFail = true;

            points = 0;
            intFail = 0;
            labelPoints.Text = Convert.ToString(points) + ", " + Convert.ToString(intFail);
        }

        private static int speed = 3;
        private int sliderSpeed = 5;

        private int points = 0;

        private int intFail = 0;
        private bool boolFail = false;

        private bool boolPause = false;

        private bool cheat = false;
        private bool legitCheat = false;

        private int horz = +1;
        private void Horzontal_Tick(object sender, EventArgs e)
        {
            if (Ball.Top < 0 || Ball.Top < FormMove.Height)
                horz = +1;
            if (Ball.Top > this.Height - Ball.Height - Slider.Height)
            {
                if (Ball.Left < Slider.Left - Ball.Width || (Ball.Left + Ball.Width) > (Slider.Left + Slider.Width) + Ball.Width)
                {
                    Horzontal.Enabled = Vertikal.Enabled = false;
                    info.Visible = boolFail = true;
                    intFail += 1;

                    if (intFail > 2)
                    {
                        pictureBox3.Visible = true;
                        info.Text = "Drücke die space Taste um zu reseten!";
                    }
                    else
                        info.Text = "Drücke die space Taste um weiter zu machen!";

                    labelPoints.Text = Convert.ToString(points) + ", " + Convert.ToString(intFail);
                }
                else
                {
                    if (speed > 20)
                        speed = 15;
                    speed++;
                    if (sliderSpeed > 30)
                        sliderSpeed = 20;
                    sliderSpeed++;
                    points += 1;
                    labelPoints.Text = Convert.ToString(points) + ", " + Convert.ToString(intFail);
                }

                horz = -1;
            }

            Ball.Top += horz * speed;
        }

        private int vert = +1;
        private void Vertikal_Tick(object sender, EventArgs e)
        {

            if (Ball.Left < 0)
                vert = +1;
            if (Ball.Left > this.Width - Ball.Width)
                vert = -1;

            Ball.Left += vert * speed;
        }

        private bool _left = false, _right = false;
        private void Watchdog_Tick(object sender, EventArgs e)
        {
            if (_left && Slider.Left > 0)
                Slider.Left -= sliderSpeed;
            if (_right && Slider.Left < this.Width - Slider.Width)
                Slider.Left += sliderSpeed;
            if (cheat)
                Slider.Location = new Point(Ball.Location.X - Ball.Width, Slider.Location.Y);
                
            if(legitCheat) {
                if (Ball.Top > this.Height - Ball.Height - Slider.Height - 10)
                    Slider.Location = new Point(Ball.Location.X - Ball.Width, Slider.Location.Y);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                _right = true;
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                _left = true;
            if (e.KeyCode == Keys.Escape)
            {
                if (!boolPause)
                {
                    boolPause = true;
                    Watchdog.Enabled = Horzontal.Enabled = Vertikal.Enabled = false;
                    info.Text = "Pause! Drücke die Escape Taste um das Spiel fortsetzen";
                    info.Visible = true;
                } else {
                    boolPause = false;
                    Watchdog.Enabled = Horzontal.Enabled = Vertikal.Enabled = true;
                    info.Visible = false;
                }
            }

            if (e.KeyCode == Keys.F8)
            {
                cheat = !cheat;
            }

            if (e.KeyCode == Keys.F9)
            {
                legitCheat = !legitCheat;
            }

            if (boolFail && e.KeyCode == Keys.Space)
            {
                Horzontal.Enabled = Vertikal.Enabled = true;
                if (intFail > 2)
                {
                    points = 0;
                    intFail = 0;
                    labelPoints.Text = Convert.ToString(points) + ", " + Convert.ToString(intFail);

                    Ball.Location = new Point(12, 12);
                }
                speed = 3;
                sliderSpeed = 5;
                pictureBox3.Visible = info.Visible = false;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                case Keys.Right:
                    _right = false;
                    break;
                case Keys.A:
                case Keys.Left:
                    _left = false;
                    break;
            }
        }

        public Point downPoint = Point.Empty;
        private void FormMove_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = new Point(e.X, e.Y);
        }

        private void FormMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty)
                Location = new Point(Left + e.X - downPoint.X, Top + e.Y - downPoint.Y);
   
        }

        private void FormMove_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = Point.Empty;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            
            cheat = legitCheat = false;

            speed = 3;
            sliderSpeed = 5;
            pictureBox3.Visible = info.Visible = false;

            Horzontal.Enabled = Vertikal.Enabled = false;
            Ball.Location = new Point(12, 12);
            Slider.Left = 10;

            info.Text = "Drücke die space Taste um zu Starten!";
            info.Visible = boolFail = true;

            points = 0;
            intFail = 0;
            labelPoints.Text = Convert.ToString(points) + ", " + Convert.ToString(intFail);
        }
    }
}
