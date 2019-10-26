using Application.Dto;
using Domain.Model;

namespace Application.Services.Mapper
{
    internal class SortOptionMapper : ISortOptionMapper
    {
        public TextSortOption MapToDomain(TextSortOptionDto dto)
        {
            return (TextSortOption)dto;
        }
    }
}
