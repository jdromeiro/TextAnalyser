using Application.Dto;

namespace Application.Services
{
    public interface ITextApplicationService
    {
        TextStatisticsDto GetTextStatistics(string document);

        string SortText(string document, TextSortOptionDto sortOption);
    }
}
