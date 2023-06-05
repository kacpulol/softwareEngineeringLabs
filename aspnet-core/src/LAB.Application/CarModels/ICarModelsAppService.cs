using Abp.Application.Services;
using LAB.CarModel.Dto;

namespace LAB.CarModel
{ 

public interface ICarModelsAppService: IAsyncCrudAppService<CarModelsDto, long, PagedCarModelsResultRequestDto, CarModelsDto, CarModelsDto>
{
    
}}