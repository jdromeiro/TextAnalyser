using System.Collections.Generic;

namespace Domain.Model
{
    public class TextStatistics
    {
        public TextStatistics()
        {
            this.Statistics = new List<Statistic>();
        }

        public List<Statistic> Statistics { get; set; }
    }
}
