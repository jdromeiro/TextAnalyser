using System.Collections.Generic;
using Domain.Services.Statistics.Builder;
using Domain.Services.Statistics.Commands;

namespace Domain.Services.Statistics.Buider
{
    internal class StatisticCommandsBuilder : IStatisticCommandsBuilder
    {
        private List<IStatisticsCommand> commands;

        public StatisticCommandsBuilder()
        {
            this.commands = new List<IStatisticsCommand>();
        }

        public IEnumerable<IStatisticsCommand> Build()
        {
            return commands;
        }

        public IStatisticCommandsBuilder WithHyphensStatisticCommand()
        {
            commands.Add(new HyphenStatisticCommand());

            return this;
        }

        public IStatisticCommandsBuilder WithSpacesStatisticCommand()
        {
            commands.Add(new SpaceCommand());

            return this;
        }

        public IStatisticCommandsBuilder WithWordStatisticCommand()
        {
            commands.Add(new WordCommand());

            return this;
        }
    }
}
