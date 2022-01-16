using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Sliders;

namespace Game.AI
{
    internal class AI_Bot
    {
        private Form main;
        private PictureBox ball;
        private Slider slider;
        private Panel player;
        private Random random = new Random();

        public AI_Bot(Form main, PictureBox ball, Slider slider, Panel player)
        {
            this.main = main;
            this.ball = ball;
            this.slider = slider;
            this.player = player;
        }

        public void playAI()
        {
            // If the ball in the range between half - third and half - 200
            if (!(random.Next((main.Height / 2) - ((main.Height / 2) / 2), (main.Height / 2) + 300) > ball.Top))
            {
                slider.IsRight = slider.IsLeft = false;
                return;
            }

            // Calculate pos
            if (ball.Left - ball.Width * random.Next(1, 4) < player.Left)
                slider.IsLeft = true;
            else
                slider.IsLeft = false;

            if (ball.Left - ball.Width * random.Next(1, 4) > player.Left)
                slider.IsRight = true;
            else
                slider.IsRight = false;

        }
    }
}
