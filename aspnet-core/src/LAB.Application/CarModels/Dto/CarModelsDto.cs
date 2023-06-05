using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace LAB.CarModel.Dto { 

[AutoMapFrom(typeof(CarModels))]
public class CarModelsDto: EntityDto<long>
{
    public bool IsDeleted { get; set; }
    public DateTime CreationTime { get; set; }
}
}