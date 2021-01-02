using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_ASPNET_Core3._1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
