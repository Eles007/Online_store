using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Entities
{
    class Motorcycle
    {
        public int MotorcycleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

    }
}
