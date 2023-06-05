using Abp.Application.Services.Dto;

namespace LAB.CarModel.Dto
{
    public class PagedCarModelsResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

