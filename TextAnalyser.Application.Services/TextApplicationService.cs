﻿using Application.Dto;
using Application.Services.Mapper;
using Domain.Services;

namespace Application.Services
{
    public class TextApplicationService : ITextApplicationService
    {
        private readonly ISortOptionMapper sortOptionMapper;
        private readonly ITextEngine textEngine;
        private readonly ITextStatisticsMapper textStatisticsAdapter;

        public TextApplicationService()
        {
            // TODO inject dependencies

            this.textEngine = new TextEngine();
            this.sortOptionMapper = new SortOptionMapper();
            this.textStatisticsAdapter = new TextStatisticsMapper();
        }

        public TextStatisticsDto GetTextStatistics(string document)
        {
            var statistics = this.textEngine.GetStatistics(document);

            return this.textStatisticsAdapter.MapToDto(statistics);
        }

        public string SortText(string document, TextSortOptionDto sortOptionDto)
        {
            var sortOption = this.sortOptionMapper.MapToDomain(sortOptionDto);

            return this.textEngine.SortText(document, sortOption);
        }
    }
}