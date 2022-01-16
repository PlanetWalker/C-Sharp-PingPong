using Game.Sliders;
using Game.Bounce;
using Game.Enemy;
using System.Collections;
using Game.AI;
using Game.ScoreSystem;

namespace BallDestroyer
{
    public partial class BallDestroyer : Form
    {
        // Global variables
        private Slider slider;
        private Bounce bounce;
        private HitBounce hitGround;
        private BallMove move;
        private AI_Bot bot;
        private Score score;

        private bool pause, fail, ai;

        // Temp enemy
        private List<Enemy> enemys;
        public BallDestroyer()
        {
            InitializeComponent();

            // initaliziere objekte
            slider = new Slider();
            bounce = new Bounce();
            hitGround = new HitBounce(this, objBall, objSlider);
            move = new BallMove(slider, bounce, hitGround, objBall);
            bot = new AI_Bot(this, objBall, slider,objSlider);
            score = new Score(objScore);

            // Create enemy list
            enemys = new List<Enemy> {};
            for (int i = 0; i < 15; i++)
            {
                enemys.Add(new Enemy(this, objBall, bounce, ref enemys));
            }

            // Round the corners
            this.Region = Round.Smooth(0, 0, this.Width, this.Height, 10, 10);
            objSlider.Region = Round.Smooth(0, 0, objSlider.Width, objSlider.Height, 10, 10);

            // No one schould see this text
            objInfo.Visible = false;

            ai = false;

            Reset();

            /* We don't need it
            objVert.Enabled = objHorz.Enabled = true;
            */
        }

        // ***************** Form Move *****************
        // This schould save the current point
        private Point movePoint = Point.Empty;

        private void oFormMove_MouseDown(object sender, MouseEventArgs e)
        {
            // User enter the form. Check is he left clicking
            if(e.Button == MouseButtons.Left)
                // Save this as a new point
                movePoint = new Point(e.X, e.Y);
        }

        private void oFormMove_MouseMove(object sender, MouseEventArgs e)
        {
            // Do nothing if movePoint == Point.Empty
            if(movePoint != Point.Empty)
                // Set the Location as a new point witch remove movePoint and add Left and Top corner
                this.Location = new Point(e.X - movePoint.X + this.Left, e.Y - movePoint.Y + this.Top);
        }

        private void oFormMove_MouseUp(object sender, MouseEventArgs e)
        {
            // User leave the form. Check is he left clicking
            if(e.Button == MouseButtons.Left)
                // Set move point emty
                movePoint = Point.Empty;
        }
        // ################# Form Move #################

        // ***************** Close *****************
        private void objClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void objClose_MouseEnter(object sender, EventArgs e)
        {
            objClose.Image = Properties.Resources.CloseRed;
        }

        private void objClose_MouseLeave(object sender, EventArgs e)
        {
            objClose.Image = Properties.Resources.CloseBlack;
        }
        // ################# Close #################


        // ***************** Keys *****************
        private void BallDestroyer_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                if (pause && !fail)
                    Start();
                else if (!pause && !fail)
                    Stop();

                if (!fail)
                    pause = !pause;
            }

            if (e.KeyCode == Keys.Space)
                if (fail)
                    Reset();

            if (e.KeyCode == Keys.F1)
                Reset();

            if (e.KeyCode == Keys.F8)
                ai = !ai;

            slider.KeyDownPosition(e.KeyCode, Keys.Left, Keys.Right);
        }

        private void BallDestroyer_KeyUp(object sender, KeyEventArgs e)
        {
            slider.KeyUpPosition(e.KeyCode, Keys.Left, Keys.Right);
        }
        // ################# Keys #################

        private void objWatchDog_Tick(object sender, EventArgs e)
        {
            // Add ggf. Pos
            slider.CalcPosition(this, objSlider);
        }

        // ***************** Ball Bounce *****************
        private void objHorz_Tick(object sender, EventArgs e)
        {
            // Active kill check
            foreach (Enemy enemy in enemys)
            {
                // This is a bool (for if) and is able to kill
                if(enemy.CheckKill())
                    score.Add();
            }

            if (ai)
                bot.playAI();

            move.MoveBall();

            if (hitGround.HitGround() && hitGround.Fail())
                Fail();

            // Add Pos
            bounce.AddHorizontal(this, objFormMove, objBall, objSlider);
        }

        private void objVert_Tick(object sender, EventArgs e)
        {
            // Add Pos
            bounce.AddVertical(this, objBall);
        }
        // ################# Ball Bounce #################

        // ***************** Reset & Stop and Start *****************
        private void Fail()
        {
            fail = true;
            objWatchDog.Enabled = objVert.Enabled = objHorz.Enabled = false;

            // To set the text
            objInfo.Text = "You Failed! With a score of " + score.GetScore.ToString() + "\nTo Reset the Game press Space!\nBot is F8\nReset is also F1";
            objInfo.Visible = true;
        }
        private void Reset()
        {
            if(fail)
            {
                fail = false;
                Reset();

            } else // if this is a normal reset -> pause
            {
                pause = true;
                fail = false;
                objWatchDog.Enabled = objVert.Enabled = objHorz.Enabled = false;
                // reset position
                objBall.Location = new Point(560, 581);
                objSlider.Location = new Point(451, objSlider.Location.Y);
                score.Reset();

                // To set the text
                objInfo.Text = "Pause!\nTo Start the Game press Escape!\nTo enable Bot press F8\nReset is F1";
                objInfo.Visible = true;
            }
        }

        private void Start()
        {
            objWatchDog.Enabled = objVert.Enabled = objHorz.Enabled = true;
            objInfo.Visible = false;
        }
        private void Stop()
        {
            objWatchDog.Enabled = objVert.Enabled = objHorz.Enabled = false;

            // To set the text
            objInfo.Text = "Pause!\nTo Start the Game press Escape!\nTo enable Bot press F8\nReset is F1";
            objInfo.Visible = true;
        }

        // ################# Reset & Stop and Start #################


        // ***************** Annimation *****************
        private static int state; // where is he?
        private string text = ""; // old text

        private void objInfo_Click(object sender, EventArgs e)
        {
            state = 0;
            if (!objAnnimation.Enabled)
            {
                // Save old text
                text = objInfo.Text;

                // reset if animation than true
                objInfo.Text = "";
            }
            else
                // give old text back
                objInfo.Text = text;

            // change enabled state
            objAnnimation.Enabled = !objAnnimation.Enabled;
        }

        private void objAnnimation_Tick(object sender, EventArgs e)
        {
            // split text
            string[] splitt = text.Split(' ');

            // check that it should not bounce outside
            if (state >= text.Length)
            {
                // Reset both
                objInfo.Text = "";
                state = 0;
            }

            // add char
            objInfo.Text += text[state];

            // encrease state
            state++;

            // turn off by press ESC
            if(!pause)
                objAnnimation.Enabled = false;
        }
    }
}