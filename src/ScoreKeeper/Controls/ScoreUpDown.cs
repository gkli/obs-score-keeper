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
    public partial class ScoreUpDown : UserControl
    {
        public class ScoreValueChangedEventArgs : EventArgs
        {
            public ScoreValueChangedEventArgs(int oldScore, int newScore)
            {
                this.OldScoreValue = oldScore;
                this.NewScoreValue = newScore;
            }
            public int OldScoreValue { get; private set; }
            public int NewScoreValue { get; private set; }
        }

        public event EventHandler<ScoreValueChangedEventArgs> ScoreValueChanged;

        public ScoreUpDown()
        {
            InitializeComponent();

            this.Value = 0;
        }


        public int Value
        {
            get
            {
                if (int.TryParse(this.txtValue.Text, out int v))
                {
                    return v;
                }
                return 0;
            }
            set
            {
                int v = value;
                if (v < 0) v = 0;

                int oldValue = this.Value;
                if (v == oldValue) return;

                this.txtValue.Text = v.ToString();

                OnScoreValueChanged(oldValue, v);
            }
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (this.Value < 1) return;
            this.Value--;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            this.Value++;
        }

        protected void OnScoreValueChanged(int oldValue, int newValue)
        {
            if (null == ScoreValueChanged) return;
            if (oldValue == newValue) return;

            ScoreValueChanged(this, new ScoreValueChangedEventArgs(oldValue, newValue));
        }

        private void ScoreUpDown_Resize(object sender, EventArgs e)
        {
            UpdateFontSize();
        }

        private void UpdateFontSize()
        {
            Font testFont = txtValue.Font;
            testFont = new Font(testFont.FontFamily, 1, testFont.Style, testFont.Unit);

            Size s = TextRenderer.MeasureText(this.txtValue.Text, testFont);

            while ((s.Height + 5) < this.txtValue.Height)
            {
                testFont = new Font(testFont.FontFamily, testFont.SizeInPoints + 1, testFont.Style, testFont.Unit);
                s = TextRenderer.MeasureText(this.txtValue.Text, testFont);
            }

            txtValue.Font = testFont;

            //this.txtValue.Font.SizeInPoints
        }
    }
}
