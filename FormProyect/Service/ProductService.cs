using FormProyect.Models;
using FormProyect.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProyect.Service
{
    internal class ProductService
    {
       private ProductRepository repository;
        public ProductService( )
        {
            this.repository = new ProductRepository();
        }

        public void AddProduct(Product product)
        {
            repository.AddProduct( product );
        }
    }
}
