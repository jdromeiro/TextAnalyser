using Application.Dto;
using Application.Services.Mapper;
using Domain.Services;

namespace Application.Services
{
    public class TextApplicationService : ITextApplicationService
    {
        private readonly ISortOptionMapper sortOptionMapper;
        private readonly ITextEngine textEngine;
        private readonly ITextStatisticsMapper textStatisticsMapper;

        public TextApplicationService()
        {
            // TODO inject dependencies

            this.textEngine = new TextEngine();
            this.sortOptionMapper = new SortOptionMapper();
            this.textStatisticsMapper = new TextStatisticsMapper();
        }

        public TextStatisticsDto GetTextStatistics(string document)
        {
            var statistics = this.textEngine.GetStatistics(document);

            return this.textStatisticsMapper.MapToDto(statistics);
        }

        public string SortText(string document, TextSortOptionDto sortOptionDto)
        {
            var sortOption = this.sortOptionMapper.MapToDomain(sortOptionDto);

            return this.textEngine.SortText(document, sortOption);
        }
    }
}
