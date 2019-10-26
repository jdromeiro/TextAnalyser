using System.Collections.Generic;
using Domain.Services.Statistics.Commands;

namespace Domain.Services.Statistics.Builder
{
    internal interface IStatisticCommandsBuilder
    {
        IEnumerable<IStatisticsCommand> Build();

        IStatisticCommandsBuilder WithHyphensStatisticCommand();

        IStatisticCommandsBuilder WithSpacesStatisticCommand();

        IStatisticCommandsBuilder WithWordStatisticCommand();
    }
}
