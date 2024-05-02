using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoService.Domain.Entities.Models.CarModels
{
    public class CarRecord
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserCarId { get; set; }
        public DateTimeOffset createdDate { get; set; } = DateTimeOffset.Now;
        public int Probeg { get; set; }
        public string RecordTask { get; set; }
        public string Comment { get; set; }
        public string Price { get; set; }

        public virtual UserCar UserCar { get; set; }
    }
}
