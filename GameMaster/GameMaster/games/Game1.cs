using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMaster
{
    public partial class Game1 : Form
    {
        public Game1()
        {
            InitializeComponent();
        }

        int speed = 3;
        int slide_speed = 10;

        int vdir = +1;
        private void vert_Tick(object sender, EventArgs e)
        {
            if(ball.Top < 0)
            {
                vdir = +1;
            } else 
            if (ball.Top > (this.Height - ball.Height - slider.Height))
            {

                if(ball.Left < slider.Left || ((ball.Left + ball.Width) > (slider.Left + slider.Width)))
                {
                    vert.Enabled = horz.Enabled = false;
                    MessageBox.Show("What the fuck!");
                }


                vdir = -1;
                speed++;
            }
            ball.Top += (vdir * speed);
        }

        int hdir = +1;
        private void horz_Tick(object sender, EventArgs e)
        {
            if (ball.Left < 0)
            {
                hdir = +1;
            }
            else 
            if (ball.Left > (this.Width - ball.Width))
            {
                hdir = -1;
            }
            ball.Left += (hdir * speed);
        }

        bool _left = false, _right = false;

        private void Game1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                _left = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                _right = true;
            }
        }

        private void watchdog_Tick(object sender, EventArgs e)
        {
            if(_right && slider.Left <(this.Width - slider.Width))
            {
                slider.Left += slide_speed;
            }

            if (_left && slider.Left > 0)
            {
                slider.Left -= slide_speed;
            }
        }

        private void Game1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _left = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                _right = false;
            }
        }
    }
}
