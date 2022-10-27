using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Cookie
    {
        // properties
        public int Id { get; set; }
        public string Name { get; set; } // Name of cookie
        public string Flavor { get; set; } // Flavor of cookie
        public int Quantity { get; set; } // Qty of dozens
                                          //[Column(TypeName = "decimal(18,4)")]
                                          //public decimal Price { get; set; } // price of a dozen 


    }
} 

