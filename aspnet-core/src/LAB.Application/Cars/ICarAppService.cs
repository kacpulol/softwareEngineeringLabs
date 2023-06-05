using Abp.Application.Services;
using LAB.Car.Dto;

namespace LAB.Car { 

public interface ICarAppService: IAsyncCrudAppService<CarDto, long, PagedCarResultRequestDto, CarDto, CarDto>
{
    
}}