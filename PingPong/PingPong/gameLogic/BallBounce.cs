using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.gameLogic
{
    public class BallBounce
    {
        public int speed; // speed of the ball
        private int horizontal;
        private int vertical;

        public BallBounce()
        {
            speed = 3;
            horizontal = +1;
            vertical = +1;
        }

        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }

        public int AddHorizontal(int ballTop, int ballHeight, int screenHeight)
        {
            // If Top have 0 pixel + (First Player) - Go to the other side
            if (ballTop < 0)
                horizontal = +1;

            // If Top habe screen width and the ball width (The ball schould not bounce outside)
            if (ballTop > screenHeight - ballHeight)
                horizontal = -1;

            // Add bounce
            ballTop += horizontal * speed;
            return ballTop;
        }

        public int AddVertical(int ballLeft, int ballWidth, int screenWidth, int playerLeftWidth, int playerRightWidth)
        {
            // If Left have 0 pixel + (First Player) - Go to the other side
            if (ballLeft < 0 + playerLeftWidth)
                vertical = +1;

            // If Left habe screen width and the ball width (The ball schould not bounce outside) and the pannel width (he schould bounce correctly)
            if (ballLeft > screenWidth - ballWidth - playerRightWidth)
                vertical = -1;

            // Add bounce
            ballLeft += vertical * speed;
            return ballLeft;
        }
    }
}
