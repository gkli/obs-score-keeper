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

    public partial class GamePeriodProperties : Form
    {
        private readonly TimePeriod _period = new TimePeriod();
        public GamePeriodProperties(TimePeriod p)
        {
            InitializeComponent();

            if (null != p)
            {
                PeriodName = p.Name;
                PeriodDuration = p.DurationInMinutes;
                IncludeInDuration = p.IncludeInTotalDurationCount;
            }
        }

        public TimePeriod Period
        {
            get { return _period; }
            //set
            //{
            //    if (_period != value)
            //    {
            //        _period = value;
            //        Sync();
            //    }
            //}
        }

        private string PeriodName
        {
            get { return this.txtName.Text; }
            set
            {
                this.txtName.Text = this.Period.Name = value;
            }
        }

        private int PeriodDuration
        {
            get { return (int)this.nudDuration.Value; }
            set
            {
                this.nudDuration.Value = this.Period.DurationInMinutes = value;
            }
        }

        private bool IncludeInDuration
        {
            get { return this.chkIncludeInDuration.Checked; }
            set
            {
                this.chkIncludeInDuration.Checked = this.Period.IncludeInTotalDurationCount = value;
            }
        }

        private void Sync()
        {
            Period.Name = PeriodName;
            Period.DurationInMinutes = PeriodDuration;
            Period.IncludeInTotalDurationCount = IncludeInDuration;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Sync();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
