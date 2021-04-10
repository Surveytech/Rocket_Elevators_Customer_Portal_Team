using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public class BuildingDetails
    {
        public long Id { get; set; }
        public string InfoKey { get; set; }
        public string Value { get; set; }
        public long? BuildingId { get; set; }

        public virtual Buildings Building { get; set; }
    }
}
