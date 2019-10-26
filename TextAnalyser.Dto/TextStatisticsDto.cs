using System.Collections.Generic;

namespace Application.Dto
{
    public class TextStatisticsDto
    {
        public TextStatisticsDto()
        {
            Statistics = new List<StatisticDto>();
        }

        public IList<StatisticDto> Statistics { get; set; }
    }
}
