using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Models
{
    class Billings
    {
        public int Id { get; set; }
        public string FoodItem { get; set; }
        public string FoodPrice { get; set; }
        public string Quantity { get; set; }
        public string TotalPrice { get; set; }


    }
}
