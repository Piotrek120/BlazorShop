using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Core
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Product(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
