using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreKeeper.Controls
{
    public partial class GameScore : UserControl
    {
        public class ScoreChangedEventArgs : EventArgs
        {
            public ScoreChangedEventArgs(ScoreUpDown.ScoreValueChangedEventArgs homeScore, ScoreUpDown.ScoreValueChangedEventArgs awayScore)
            {
                this.HomeScore = homeScore;
                this.AwayScore = awayScore;
            }
            public ScoreUpDown.ScoreValueChangedEventArgs HomeScore { get; private set; }
            public ScoreUpDown.ScoreValueChangedEventArgs AwayScore { get; private set; }
        }

        public event EventHandler<ScoreChangedEventArgs> ScoreChanged;

        public GameScore()
        {
            InitializeComponent();
        }

        public int HomeScore
        {
            get
            {
                return this.homeScore.Value;
            }
            set
            {
                this.homeScore.Value = value;
            }
        }
        public int AwayScore
        {
            get { return awayScore.Value; }
            set
            {
                awayScore.Value = value;
            }
        }

        private void homeScore_ScoreValueChanged(object sender, ScoreUpDown.ScoreValueChangedEventArgs e)
        {
            OnScoreChanged(e, null);
        }

        private void awayScore_ScoreValueChanged(object sender, ScoreUpDown.ScoreValueChangedEventArgs e)
        {
            OnScoreChanged(null, e);
        }

        protected void OnScoreChanged(ScoreUpDown.ScoreValueChangedEventArgs home, ScoreUpDown.ScoreValueChangedEventArgs away)
        {
            if (null == ScoreChanged) return;

            ScoreChanged(this, new ScoreChangedEventArgs(home, away));
        }
    }
}
