using Abp.Application.Services;
using Abp.Domain.Repositories;
using LAB.Car.Dto;

namespace LAB.Car
{

    public class CarAppService : AsyncCrudAppService<Cars, CarDto, long, PagedCarResultRequestDto, CarDto, CarDto>, ICarAppService
    {
        public CarAppService(IRepository<Cars, long> repository) : base(repository)
        {
        }
    }
}