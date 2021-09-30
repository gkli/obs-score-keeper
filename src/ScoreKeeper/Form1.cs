using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreKeeper
{
    public partial class Form1 : Form
    {
        private readonly Config cfg;

        public Form1()
        {
            InitializeComponent();

            cfg = Config.Load(System.IO.Path.Combine(System.Environment.CurrentDirectory, "settings.json"));

            this.ClockFilePath = cfg.TimeFilePath;
            this.ScoreFilePath = cfg.ScoreFilePath;
            this.GoalImageSrcFilePath = cfg.ScoreChangedImageSrcPath;
            this.GoalImageDstFilePath = cfg.ScoreChangedImageDstPath;

            LoadPeriods(cfg.Periods);

            gameScore1.AwayScore = 1;
            gameScore1.HomeScore = 1;

            gameScore1.AwayScore = 0;
            gameScore1.HomeScore = 0;
        }

        private string ClockFilePath
        {
            get { return this.txtClockFile.Text; }
            set
            {
                this.txtClockFile.Text = value;
                if (null != cfg)
                {
                    cfg.TimeFilePath = value;
                }
            }
        }
        private string ScoreFilePath
        {
            get { return this.txtScoreFile.Text; }
            set
            {
                this.txtScoreFile.Text = value;
                if (null != cfg)
                {
                    cfg.ScoreFilePath = value;
                }
            }
        }
        private string GoalImageSrcFilePath
        {
            get { return this.txtGoalImageSrcFileName.Text; }
            set
            {
                this.txtGoalImageSrcFileName.Text = value;
                if (null != cfg)
                {
                    cfg.ScoreChangedImageSrcPath = value;
                }
            }
        }

        private string GoalImageDstFilePath
        {
            get { return this.txtGoalImageDstFileName.Text; }
            set
            {
                this.txtGoalImageDstFileName.Text = value;
                if (null != cfg)
                {
                    cfg.ScoreChangedImageDstPath = value;
                }
            }
        }


        #region Config
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (null == cfg) return;

            cfg.Save();
        }

        private void btnBrowseScoreFile_Click(object sender, EventArgs e)
        {
            string file = BrowseFileSave(cfg.ScoreFilePath, true);
            if (false == string.IsNullOrWhiteSpace(file))
            {
                this.ScoreFilePath = file;
            }
        }

        private void btnBrowseClockFile_Click(object sender, EventArgs e)
        {
            string file = BrowseFileSave(cfg.TimeFilePath, true);
            if (false == string.IsNullOrWhiteSpace(file))
            {
                this.ClockFilePath = file;
            }
        }

        private void btnBrowseGoalImageSrc_Click(object sender, EventArgs e)
        {
            string file = BrowseFileOpen(cfg.ScoreChangedImageSrcPath, false);
            if (false == string.IsNullOrWhiteSpace(file))
            {
                this.GoalImageSrcFilePath = file;
            }
        }

        private void btnBrowseGoalImageDst_Click(object sender, EventArgs e)
        {
            string file = BrowseFileSave(cfg.ScoreChangedImageDstPath, false);
            if (false == string.IsNullOrWhiteSpace(file))
            {
                this.GoalImageDstFilePath = file;
            }
        }

        //private void chkGenGoalImage_CheckedChanged(object sender, EventArgs e)
        //{
        //    this.GenerateGoalImage = chkGenGoalImage.Checked;
        //}

        private string BrowseFileSave(string defaultFileName, bool isText)
        {
            return BrowseFile<SaveFileDialog>(defaultFileName, isText);
        }

        private string BrowseFileOpen(string defaultFileName, bool isText)
        {
            return BrowseFile<OpenFileDialog>(defaultFileName, isText);
        }

        private string BrowseFile<T>(string defaultFileName, bool isText) where T : FileDialog, new()
        {
            using (T d = new T())
            {
                if (isText)
                {
                    d.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                }
                else
                {
                    d.Filter = "animated gif (*.gid)|*.gif|All files (*.*)|*.*";
                }

                d.FileName = defaultFileName;
                if (d.ShowDialog(this) == DialogResult.OK)
                {
                    return d.FileName;
                }
            }

            return string.Empty;
        }

        private void btnAddPeriod_Click(object sender, EventArgs e)
        {
            using (GamePeriodProperties diag = new GamePeriodProperties(new TimePeriod() { Name = "{new period}" }))
            {
                if (diag.ShowDialog(this) == DialogResult.OK)
                {
                    // this.lbPeriods.Items.Add(diag.Period);
                    cfg.Periods.Add(diag.Period);
                    this.lbPeriods.RefreshItems();
                    this.cbPeriods.RefreshItems();
                }
            }
        }

        private void btnRemovePeriod_Click(object sender, EventArgs e)
        {
            if (lbPeriods.SelectedItem != null)
            {
                cfg.Periods.Remove(lbPeriods.SelectedItem as TimePeriod);
            }
        }

        private void LoadPeriods(IEnumerable<TimePeriod> periods)
        {
            this.lbPeriods.DataSource = periods;

            this.cbPeriods.DataSource = periods;
            this.cbPeriods.DisplayMember = "Name";

            //this.lbPeriods.Items.Clear();

            //foreach (var p in periods)
            //{
            //    this.lbPeriods.Items.Add(p);
            //}
        }

        private void lbPeriods_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //e.Location
            var idx = this.lbPeriods.IndexFromPoint(e.Location);
            if (idx == ListBox.NoMatches) return;

            TimePeriod p = this.lbPeriods.Items[idx] as TimePeriod;
            if (null == p) return;

            using (GamePeriodProperties diag = new GamePeriodProperties(p))
            {
                if (diag.ShowDialog(this) == DialogResult.OK)
                {
                    p.DurationInMinutes = diag.Period.DurationInMinutes;
                    p.Name = diag.Period.Name;
                    p.IncludeInTotalDurationCount = diag.Period.IncludeInTotalDurationCount;
                    lbPeriods.RefreshItem(idx);

                    cbPeriods.RefreshItems();

                }
            }
        }
        #endregion



        #region Run

        bool _running = false;
        // int _numberOfTicks = 0;

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            _running = !_running;
            SetControlState(_running);
        }

        private void SetControlState(bool isRunning)
        {
            this.btnReset.Enabled = !isRunning;
            //this.txtClockFormat.ReadOnly = isRunning;
            this.txtClockValue.ReadOnly = isRunning;
            this.cbPeriods.Enabled = !isRunning;
            this.clockTimer.Enabled = isRunning;

            if (isRunning)
            {
                this.btnStartStop.Text = "Stop";

            }
            else
            {
                this.btnStartStop.Text = "Start";
            }
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                string[] parts = this.txtClockValue.Text.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

                int hours = 0, minutes = 0, seconds = 0;

                switch (parts.Length)
                {
                    case 1: //seconds only
                        seconds = int.Parse(parts[0]);
                        break;
                    case 2: //mm:ss
                        minutes = int.Parse(parts[0]);
                        seconds = int.Parse(parts[1]);
                        break;
                    case 3: //hh:mm:ss
                        hours = int.Parse(parts[0]);
                        minutes = int.Parse(parts[1]);
                        seconds = int.Parse(parts[2]);
                        break;
                }

                TimeSpan ts = TimeSpan.FromHours(hours);
                ts = ts.Add(TimeSpan.FromMinutes(minutes));
                ts = ts.Add(TimeSpan.FromSeconds(seconds));
                ts = ts.Add(TimeSpan.FromSeconds(1));

                //_numberOfTicks++;
                UpdateClockDisplay((int)ts.TotalSeconds);
            }
            catch
            {
                UpdateClockDisplay(0);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //_numberOfTicks = 0;
            UpdateClockDisplay(0);
        }

        private void UpdateClockDisplay(int totalSeconds)
        {
            //parse format string

            TimeSpan ts = TimeSpan.FromSeconds(totalSeconds);

            int totalMinutes = (int)ts.TotalMinutes;
            int seconds = (int)ts.Seconds;

            this.txtClockValue.Text = string.Format("{0:00}:{1:00}", totalMinutes, seconds);

            try
            {
                System.IO.File.WriteAllText(cfg.TimeFilePath, this.txtClockValue.Text);
            }
            catch { }

        }

        private void gameScore1_ScoreChanged(object sender, Controls.GameScore.ScoreChangedEventArgs e)
        {
            string score = string.Format("{0} : {1}", gameScore1.HomeScore, gameScore1.AwayScore);

            try
            {
                System.IO.File.WriteAllText(cfg.ScoreFilePath, score);
            }
            catch { }

            if (false == _running || this.chkSkipGoalImage.Checked) return;

            if (false == string.IsNullOrWhiteSpace(cfg.ScoreChangedImageSrcPath) && System.IO.File.Exists(cfg.ScoreChangedImageSrcPath))
            {
                Controls.ScoreUpDown.ScoreValueChangedEventArgs args = e.AwayScore;
                if (null == args) args = e.HomeScore;

                if (null == args) return;

                if (args.NewScoreValue > args.OldScoreValue)
                {
                    //Do something here... only if score is going up
                    //write image, set timer...
                    if (false == goalImageTimer.Enabled)
                    {
                        try
                        {
                            System.IO.File.Copy(cfg.ScoreChangedImageSrcPath, cfg.ScoreChangedImageDstPath, true);
                            goalImageTimer.Enabled = true; //set interval based on config when available
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
            }
        }

        private void cbPeriods_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimePeriod p = cbPeriods.SelectedItem as TimePeriod;
            if (null == p) return;

            if (false == p.IncludeInTotalDurationCount)
            {
                UpdateClockDisplay(0);
                return;
            }

            int totalOffSet = 0;

            for (int i = 0; i < cbPeriods.SelectedIndex; i++)
            {
                p = cbPeriods.Items[i] as TimePeriod;
                if (null == p) continue;
                if (false == p.IncludeInTotalDurationCount) continue;

                totalOffSet = p.DurationInMinutes * 60;
            }

            UpdateClockDisplay(totalOffSet);
        }



        #endregion

        private void goalImageTimer_Tick(object sender, EventArgs e)
        {
            //delete file
            try
            {
                if (System.IO.File.Exists(cfg.ScoreChangedImageDstPath))
                {
                    System.IO.File.Delete(cfg.ScoreChangedImageDstPath);
                }
            }
            catch { }
            goalImageTimer.Enabled = false;
        }

    }
}
