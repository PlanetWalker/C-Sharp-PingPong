using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.ScoreSystem
{
    internal class Score
    {
        private int score;
        private Label scoreLabel;

        public int GetScore { get { return score; } }

        public Score(Label scoreLabel)
        {
            this.scoreLabel = scoreLabel;
            score = 0;
            scoreLabel.Text = "Score: " + score.ToString();
        }

        public void Add()
        {
            score++;
            scoreLabel.Text = "Score: " + score.ToString();
        }
        public void Remove()
        {
            score--;
            scoreLabel.Text = "Score: " + score.ToString();
        }
        public void Reset()
        {
            score = 0;
            scoreLabel.Text = "Score: " + score.ToString();
        }
    }
}
