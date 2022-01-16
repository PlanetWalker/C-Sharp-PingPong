using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Sliders;

namespace Game.Bounce
{
    internal class BallMove
    {
        private int oldSpeed;
        private int newSpeed;
        private int moveSpeed;

        private Slider slider;
        private HitBounce hitBall;
        private Bounce bounce;
        private PictureBox ball;

        public int MoveSpeed { get { return moveSpeed; } set { moveSpeed = value; } }

        public BallMove(Slider slider, Bounce bounce, HitBounce hitBall, PictureBox ball)
        {
            this.hitBall = hitBall;
            this.slider = slider;
            this.bounce = bounce;
            this.ball = ball;

            oldSpeed = bounce.GetSpeed;
            newSpeed = 1;
            moveSpeed = 5;
        }

        public void MoveBall()
        {
            // If the ball not in the region
            if (hitBall.NearGround(50))
            {
                // The ball is in the region

                // Set the new speed if it in the region
                bounce.SetSpeed = newSpeed;
                if (slider.IsRight)
                {
                    // Do the ball in the right direction
                    if (bounce.Vertical == -1)
                        bounce.Vertical = 0;

                    ball.Left += moveSpeed;
                }

                if (slider.IsLeft)
                {
                    // Do the ball in the right direction
                    if (bounce.Vertical == +1)
                        bounce.Vertical = 0;

                    ball.Left -= moveSpeed;

                }
                return;

            }
            // Do this if not

            if(bounce.GetSpeed == newSpeed)
            {
                // Reset the speed
                bounce.SetSpeed = oldSpeed;
                return;
            } 

            // Save the old speed if the ball outside
            oldSpeed = bounce.GetSpeed;
            return;

        }
    }
}
