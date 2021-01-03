using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_ASPNET_Core3._1.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
