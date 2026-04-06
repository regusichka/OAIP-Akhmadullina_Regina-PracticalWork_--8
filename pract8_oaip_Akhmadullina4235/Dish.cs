using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract8_oaip_Akhmadullina4235
{
    public class Dish
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string Ingredients { get; set; }

        public Dish(int number, string name, string category, double price, string ingredients)
        {
            Number = number;
            Name = name;
            Category = category;
            Price = price;
            Ingredients = ingredients;
        }

        public override string ToString()
        {
            return $"{Number} | {Name} | {Category} | {Price} | {Ingredients}";
        }
    }
}