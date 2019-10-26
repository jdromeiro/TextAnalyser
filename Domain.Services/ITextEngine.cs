using Domain.Model;

namespace Domain.Services
{
    public interface ITextEngine
    {
        TextStatistics GetStatistics(string text);

        string SortText(string text, TextSortOption textSortOption);
    }
}
