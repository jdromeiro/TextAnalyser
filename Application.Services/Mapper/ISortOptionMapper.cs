using Application.Dto;
using Domain.Model;

namespace Application.Services.Mapper
{
    public interface ISortOptionMapper
    {
        TextSortOption MapToDomain(TextSortOptionDto dto);
    }
}
