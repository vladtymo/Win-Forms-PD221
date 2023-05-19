using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_multi_forms
{
    public class Product
    {
        private static int nextId = 1000;
        public int ID { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
            this.ID = nextId++;
        }

        public override string ToString()
        {
            return $"[{ID}]: {Name} costs {Price}$";
        }
    }
}
