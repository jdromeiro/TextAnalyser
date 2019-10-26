using System.Collections.Generic;
using Domain.Services.Statistics.Commands;

namespace Domain.Services.Statistics.Builder
{
    internal interface IStatisticStrategiesBuilder
    {
        IEnumerable<IStatisticStrategy> Build();

        IStatisticStrategiesBuilder WithHyphensStatisticStrategy();

        IStatisticStrategiesBuilder WithSpacesStatisticStrategy();

        IStatisticStrategiesBuilder WithWordStatisticStrategy();
    }
}
