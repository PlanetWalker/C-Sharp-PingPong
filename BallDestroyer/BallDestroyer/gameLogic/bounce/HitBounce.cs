using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Bounce
{
    internal class HitBounce
    {
        private Form screen;
        private PictureBox ball;
        private Panel slider;

        public HitBounce(Form screen, PictureBox ball, Panel slider)
        {
            this.screen = screen;
            this.ball = ball;
            this.slider = slider;
        }

        public bool HitGround()
        {
            // if the ball hit the ground
            if (ball.Top > screen.Height - ball.Height - slider.Height)
            {
                return true;
            }
            return false;
        }

        public bool Fail()
        {
            // If the ball hit ground without slider
            // If the ball on the left side of the ball || if the ball on the right side ;)
            if (ball.Left < slider.Left - ball.Width || (ball.Left + ball.Width) > (slider.Left + slider.Width) + ball.Width)
                return true;
            return false;
        }

        public bool NearGround(int pixel)
        {
            // Check if the ball didn't hit the gound
            if (!Fail())
                // If the ball near ground (pixel)
                if (ball.Top > screen.Height - ball.Height - slider.Height - pixel)
                    return true;
            return false;
        }

    }
}
