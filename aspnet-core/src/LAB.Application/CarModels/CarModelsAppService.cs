using Abp.Application.Services;
using Abp.Domain.Repositories;
using LAB.CarModel.Dto;

namespace LAB.CarModel
{

    public class CarModelsAppService : AsyncCrudAppService<CarModels, CarModelsDto, long, PagedCarModelsResultRequestDto, CarModelsDto, CarModelsDto>, ICarModelsAppService
    {
        public CarModelsAppService(IRepository<CarModels, long> repository) : base(repository)
        {
        }
    }
}