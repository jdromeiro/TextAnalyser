using Application.Dto;
using Domain.Model;

namespace Application.Services.Mapper
{
    public interface ITextStatisticsMapper
    {
        TextStatisticsDto MapToDto(TextStatistics dto);
    }
}
