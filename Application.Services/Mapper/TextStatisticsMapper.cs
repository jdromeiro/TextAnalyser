using Application.Dto;
using Domain.Model;

namespace Application.Services.Mapper
{
    internal class TextStatisticsMapper : ITextStatisticsMapper
    {
        public TextStatisticsDto MapToDto(TextStatistics dto)
        {
            var statisticsDto = new TextStatisticsDto();

            foreach (var stat in dto.Statistics)
            {
                var statisticDto = new StatisticDto()
                {
                    Count = stat.Value,
                    Type = (StatisticTypeDto)stat.Type
                };

                statisticsDto.Statistics.Add(statisticDto);
            }

            return statisticsDto;
        }
    }
}
