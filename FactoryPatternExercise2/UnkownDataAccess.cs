using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class UnkownDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data into a list");

            var product1 = new Product()
            {
                Name = "Macbook",
                Price = 799.99
            };

            var product2 = new Product()
            {
                Name = "Vizo TV",
                Price = 999.99
            };

            var product3 = new Product()
            {
                Name = "Toshiba computer",
                Price = 499.99
            };

            var listOfProducts = new List<Product>() { product1,product2, product3 };

            return listOfProducts;

        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from UnkownDataAccess database");
        }
    }
}
