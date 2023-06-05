using Abp.Application.Services.Dto;

namespace LAB.Car.Dto
{
    public class PagedCarResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

