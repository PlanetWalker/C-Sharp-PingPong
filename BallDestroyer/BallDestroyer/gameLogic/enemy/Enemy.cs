using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Bounce;

namespace Game.Enemy
{
    internal class Enemy
    {
        private Form mainFrame;
        private PictureBox ball;
        private BallBounce bounce;
        private Random random;
        private List<Enemy> enemyList;
        private Panel enemy;

        public Panel GetPanel { get { return enemy; } set { enemy = value; } }

        public Enemy(Form mainFrame, PictureBox ball, BallBounce bounce, ref List<Enemy> enemyList)
        {

            this.mainFrame = mainFrame;
            this.ball = ball;
            this.bounce = bounce;
            this.random = new Random();
            this.enemyList = enemyList;

            // create enemy type
            enemy = new Panel();
            // Set properties
            SetProperties();
        }
        public void SetProperties()
        {
            enemy.BackColor = Color.Red;
            LocalizeSize();
            LocalizeLocation();
            Add();
        }

        public void LocalizeLocation()
        {
            int x, y, retry;
            bool checkFreeSpace;
            // it is need to check Space
            checkFreeSpace = false;
            retry = 0;

            // while it need to check spache
            do {
                // Get random x and y
                x = random.Next(0, mainFrame.Width - 40);
                y = random.Next(30, mainFrame.Height - 300);

                // set virtual location
                enemy.Location = new Point(x, y);

                // test if there something
                foreach (Enemy enemys in enemyList)
                {
                    // Enemy schould not test himself && If not the bounds intersects && if not hit the ball
                    if (this.GetPanel != enemys.GetPanel && !enemy.Bounds.IntersectsWith(enemys.GetPanel.Bounds) && !enemy.Bounds.IntersectsWith(ball.Bounds))
                    {
                        // we don't recalc a position
                        checkFreeSpace = false;
                    } else
                        // if it need to recalc
                        checkFreeSpace = true;
                }
                // Don't retry to often
                retry++;
                if(retry > 15)
                    checkFreeSpace = false;

            } while (checkFreeSpace);

        }

        public void LocalizeSize()
        {
            enemy.Size = new Size(30, 30);
        }

        public void Add()
        {
            mainFrame.Controls.Add(enemy);
        }

        public bool CheckKill()
        {
            // kill enemy type
            if (ball.Bounds.IntersectsWith(enemy.Bounds))
            {

                // calculate where was the hit
                bool hitX, hitY;
                // If the ball on the left side of the ball || if the ball on the right side
                hitX = ball.Left < enemy.Left - ball.Width || (ball.Left + ball.Width) > (enemy.Left + enemy.Width);
                hitY = ball.Top < enemy.Top - ball.Height || (ball.Top + ball.Height) > (enemy.Top + enemy.Height);

                // Side - hitX
                if (hitX)
                    bounce.Vertical = 0;

                // Up & Down - hitY
                if (hitY)
                {
                    bounce.Horizontal = 0;
                    bounce.Vertical = 0;
                }

                // Delete
                mainFrame.Controls.Remove(enemy);
                enemy.Dispose();

                // Set new
                enemy = new Panel();
                SetProperties();

                return true;
            }
            return false;
        }

        public void KillALL()
        {
            foreach (Enemy enemys in enemyList)
            {

                // Delete
                mainFrame.Controls.Remove(enemys.GetPanel);
                enemys.GetPanel.Dispose();

                // Set new
                enemys.GetPanel = new Panel();
                SetProperties();
            }
        }
    }
}
