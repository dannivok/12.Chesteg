using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class VendingMachine
    {
        private List<Product> _products;
        private int _balance;
        private int _income;

        public int Balance { get; }
        public int Income { get; }


        private ProductCategory ParseCategory(string szoveg)
        {

            switch (szoveg)
            {
                case "Drink":
                    return ProductCategory.Drink;
                    break;

                case "Snack":
                    return ProductCategory.Snack;
                    break;

                case "Food":
                    return ProductCategory.Food;
                    break;

                default: return ProductCategory.Snack;
            }
        }

        public void LoadProducts(string filename)
        {
            List<Product> _products = new List<Product>();
            string[] lines = File.ReadAllLines("products.txt");
            foreach (var line in lines)
            {
                string[] parts = lines[0].Split(";");
                int number = int.Parse(parts[2]);
                int stock = int.Parse(parts[3]);
                ProductCategory category = ParseCategory(parts[4]);
                _products.Add(new Product(parts[0], parts[1], number, stock, category));
            }
        }

        public VendingMachine(string filename)
        {
            _balance = 0;
            _income = 0;
            LoadProducts(filename);
        }

        public void InsertCoin(int coin)
        {
            _balance += coin;
        }

        public int ReturnChange()
        {
            int change=_balance;
            _balance = 0;
            return change;  
        }

        public Product FindProduct(string keresettkod)
        {
            foreach (var item in _products) 
            {
                if (item.Code == keresettkod) 
                {
                    return item;
                }      
            }
            return null;
        }

        public void ListProducts()
        {
            foreach(var item in _products)
            {
                if()
                Console.WriteLine(item.Code);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Category);
            }
        }
    }
}
