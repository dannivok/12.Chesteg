using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        public enum Weekday
        {
            Monday, Tuesday, Wednesday
        }
        Weekday today = Weekday.Monday;

        private string _code { get; set; }
        private string _name { get; set; }
        private int _price { get; set; }
        private int _stock { get; set; }
        private ProductCategory _category;

        public string Code { get { return _code; } }
        public string Name { get { return _name; } }
        public int Price { get { return _price; } }
        public int Stock { get { return _stock; } }
        public ProductCategory Category { get { return _category; } }
        public bool IsAvaible
        {
            get
            {
                if (Stock > 1)
                {
                    return true;
                }
                return false;
            }
        }


        public Product(string Code, string Name, int Price, int Stock, ProductCategory Category)
        {
            _code = Code;
            _name = Name;
            _price = Price;
            _stock = Stock;
            _category = Category;

        }

        public void Sell()
        {
            _stock -= 1;
        }

        //public bool IsAvaible()

    }
}
