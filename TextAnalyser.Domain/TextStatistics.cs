using System.Collections.Generic;
using Domain.Services.Statistics;

namespace Domain.Model
{
    public class TextStatistics
    {
        public TextStatistics()
        {
            this.Statistics = new List<Statistic>();
        }

        public IList<Statistic> Statistics { get; set; }
    }
}
