using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMaster.games
{
    public partial class Game1_1 : Form
    {
        public Point downPoint = Point.Empty;

        public Game1_1()
        {
            InitializeComponent();
        }

        bool _left = false, _right = false;
        private void Watchdog_Tick(object sender, EventArgs e)
        {
            if (_right && Slider.Left < (this.Width - Slider.Width))
            {
                Slider.Left += 10;
            }

            if (_left && Slider.Left > 0)
            {
                Slider.Left -= 10;
            }
        }


        private void Game1_1_KeyDown(object sender, KeyEventArgs e)
        {


            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.A:
                    _left = true;
                    break;
                case Keys.Right:
                case Keys.D:
                    _right = true;
                    break;

            }
        }

        private void Game1_1_KeyUp(object sender, KeyEventArgs e)
        {

            switch(e.KeyCode)
            {
                case Keys.Left:
                case Keys.A:
                    _left = false;
                    break;
                case Keys.Right:
                case Keys.D:
                    _right = false;
                    break;

            }

            /* Why so?
            if (e.KeyCode == Keys.Left)
            {
                _left = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                _right = false;
            }
            */
        }

        int y = +1;
        private void Y_Tick(object sender, EventArgs e)
        {
            if (Ball.Top < 0)
                y = +1;
            if (Ball.Top > (this.Height - Ball.Height - Slider.Height)) { 
                if (Ball.Left < Slider.Left || ((Ball.Left + Ball.Width) > (Slider.Left + Slider.Width)))
                {
                    //Y.Enabled = X.Enabled = false;
                }
            y = -1;
            }

            Ball.Top += y;
        }

        int x = +1;
        private void X_Tick(object sender, EventArgs e)
        {
            if (Ball.Left < 0)
                x = +1;
            if (Ball.Left > this.Width - Ball.Width)
                x = -1;

            Ball.Left += x;
        }

        private void Grabbing_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = new Point(e.X, e.Y);
        }

        private void Grabbing_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty)
                this.Location = new Point(this.Left + e.X - downPoint.X, this.Top + e.Y - downPoint.Y);
        }

        private void Grabbing_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = Point.Empty;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
