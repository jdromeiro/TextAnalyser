﻿using Application.Dto;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        private ITextApplicationService textApplicationService;

        public TextController()
        {
            this.textApplicationService = new TextApplicationService();
        }

        // GET api/statistics
        [HttpGet("statistics")]
        public ActionResult<TextStatisticsDto> Get([FromBody] string text)
        {
            return this.textApplicationService.GetTextStatistics(text);
        }

        // PUT api/sort/1
        [HttpGet("sort{sortId}")]
        public ActionResult<string> Get([FromBody] string text, int sortId)
        {
            var sortOption = (TextSortOptionDto)sortId;

            return this.textApplicationService.SortText(text, sortOption);
        }
    }
}