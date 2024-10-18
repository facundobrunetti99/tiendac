using FormProyect.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProyect.Repository
{
    internal class ProductRepository
    {
        string connectionString = "Server=localhost;Database=form_database;User ID=root;SslMode=None;";
        public void AddProduct(Product product)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Product (Name, Price, Cant,Total,Description) VALUES(@Name,@Price,@Stock,@Total,@Description)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("Stock", product.Cant);
                    command.Parameters.AddWithValue("@Total", product.GetTotal());
                    command.Parameters.AddWithValue("@Description", product.Description);
                    command.ExecuteNonQuery();
                } ;

            }

        }

    }
}
