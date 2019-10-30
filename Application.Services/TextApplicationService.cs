using Application.Dto;
using Application.Services.Mapper;
using Domain.Services;

namespace Application.Services
{
    public class TextApplicationService : ITextApplicationService
    {
        private readonly ISortOptionMapper sortOptionMapper;
        private readonly ITextEngine textEngine;
        private readonly ITextStatisticsMapper TextStatisticsMapper;

        public TextApplicationService(
            ITextEngine textEngine,
            ISortOptionMapper sortOptionMapper,
            ITextStatisticsMapper TextStatisticsMapper
            )
        {
            this.textEngine = textEngine;
            this.sortOptionMapper = sortOptionMapper;
            this.TextStatisticsMapper = TextStatisticsMapper;
        }

        public TextStatisticsDto GetTextStatistics(string text)
        {
            var statistics = this.textEngine.GetStatistics(text);

            return this.TextStatisticsMapper.MapToDto(statistics);
        }

        public string SortText(string text, TextSortOptionDto sortOptionDto)
        {
            var sortOption = this.sortOptionMapper.MapToDomain(sortOptionDto);

            return this.textEngine.SortText(text, sortOption);
        }
    }
}
