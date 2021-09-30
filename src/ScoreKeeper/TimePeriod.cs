using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeeper
{
    public class TimePeriod
    {
        public int DurationInMinutes { get; set; }
        public string Name { get; set; }
        public bool IncludeInTotalDurationCount { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1} min", this.Name, this.DurationInMinutes);
        }
    }
}
