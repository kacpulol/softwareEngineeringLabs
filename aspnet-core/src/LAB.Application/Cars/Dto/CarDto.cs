using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace LAB.Car.Dto { 

[AutoMapFrom(typeof(Cars))]
public class CarDto: EntityDto<long>
{
    public bool IsDeleted { get; set; }
    public DateTime CreationTime { get; set; }
}
}