using Application.Dto;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        private readonly ITextApplicationService textApplicationService;

        public TextController(ITextApplicationService textApplicationService)
        {
            this.textApplicationService = textApplicationService;
        }

        // POST api/statistics
        [HttpPost("statistics")]
        public ActionResult<TextStatisticsDto> Get([FromBody] string text)
        {
            return this.textApplicationService.GetTextStatistics(text);
        }

        // POST api/sort/1
        [HttpPost("sort/{sortId}")]
        public ActionResult<string> Get([FromBody] string text, int sortId)
        {
            var sortOption = (TextSortOptionDto)sortId;

            return this.textApplicationService.SortText(text, sortOption);
        }
    }
}
