using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using LAB.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB.CarModel
{
    public class CarModels : Entity<long>, ISoftDelete, IHasCreationTime
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
