namespace Game.Bounce
{
    public class BallBounce
    {
        private int speed; // speed of the ball
        private int horizontal;
        private int vertical;

        public int GetSpeed { get { return speed; } }
        public int SetSpeed { set { speed = value; } }
        // to get and set a new direction
        public int Horizontal { get { return horizontal; } set { if (horizontal == +1) { horizontal = -1; } else if (horizontal == -1) { horizontal = +1; } } }
        public int Vertical { get { return vertical; } set { if (vertical == +1) { vertical = -1; } else if (vertical == -1) { vertical = +1; } } }
        
        public BallBounce()
        {
            speed = 3;
            horizontal = +1;
            vertical = +1;
        }

        public void AddHorizontal(Form screen, Panel topSpace , PictureBox ball, Panel player)
        {
            // If Top have 0 pixel + (First Player) - Go to the other side
            if (ball.Top < 0 + topSpace.Height || ball.Top < player.Height + topSpace.Height)
                horizontal = +1;

            // If Top habe screen width and the ball width (The ball schould not bounce outside)
            if (ball.Top > screen.Height - ball.Height - player.Height)
                horizontal = -1;

            // Add bounce
            ball.Top += horizontal * speed;
        }

        public void AddVertical(Form screen, PictureBox ball)
        {
            // If Left have 0 pixel + (First Player) - Go to the other side
            if (ball.Left < 0)
                vertical = +1;

            // If Left habe screen width and the ball width (The ball schould not bounce outside) and the pannel width (he schould bounce correctly)
            if (ball.Left > screen.Width - ball.Width)
                vertical = -1;

            // Add bounce
            ball.Left += vertical * speed;
        }

    }
}
