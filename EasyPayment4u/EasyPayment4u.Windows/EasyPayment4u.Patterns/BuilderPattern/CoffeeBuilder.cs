using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Patterns.BuilderPattern
{
    public class CoffeeBuilder : IDrinkBuilder
    {
        Drink objDrink;
        public CoffeeBuilder()
        {
            objDrink = new Drink("Coffee");
        }

        public void AddWater()
        {
            
        }

        public void AddPowder()
        {
            
        }

        public Drink Drink
        {
            get { return objDrink; }
        }
    }
}
