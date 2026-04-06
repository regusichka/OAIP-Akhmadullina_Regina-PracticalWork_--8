using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract8_oaip_Akhmadullina4235
{
    public class Restaurant
    {
        public string Name { get; set; }
        public Dish Dish { get; set; }

        public Restaurant(string name, Dish dish)
        {
            Name = name;
            Dish = dish;
        }

        public override string ToString()
        {
            return $"Ресторан: {Name} | Блюдо: {Dish}";
        }
    }

}
