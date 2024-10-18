using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProyect.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Cant { get; set; }
        
        public Product(int id,  string name, string description, decimal price, int cant)
        {
          this.Id=id;
          this.Name=name;
          this.Price=price;
          this.Cant = cant;
          this.Description=description;
        }
            
        public decimal GetTotal()
        {
            decimal total = Price*Cant;
            return total;
        }


    }
}
