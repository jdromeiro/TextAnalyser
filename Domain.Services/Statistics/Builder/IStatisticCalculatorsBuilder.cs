namespace Domain.Services.Statistics.Builder
{
    using System.Collections.Generic;

    internal interface IStatisticCalculatorsBuilder
    {
        IEnumerable<IStatisticCalculator> Build();

        IStatisticCalculatorsBuilder WithHyphensCount();

        IStatisticCalculatorsBuilder WithSpacesCount();

        IStatisticCalculatorsBuilder WithWordsCount();
    }
}
