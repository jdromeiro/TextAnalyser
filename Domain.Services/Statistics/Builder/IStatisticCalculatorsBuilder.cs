using System.Collections.Generic;

namespace Domain.Services.Statistics.Builder
{
    internal interface IStatisticCalculatorsBuilder
    {
        IEnumerable<IStatisticCalculator> Build();

        IStatisticCalculatorsBuilder WithHyphensCount();

        IStatisticCalculatorsBuilder WithSpacesCount();

        IStatisticCalculatorsBuilder WithWordsCount();
    }
}
