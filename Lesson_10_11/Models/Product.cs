using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_11.Models
{
    public class Product
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? IdCategory { get; set; }
        public override string ToString()
        {
            return $"{Name} | {Price} ";

        }
    }
}
