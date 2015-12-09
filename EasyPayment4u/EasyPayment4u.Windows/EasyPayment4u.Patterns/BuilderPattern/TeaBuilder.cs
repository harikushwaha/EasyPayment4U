using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Patterns.BuilderPattern
{
    public class TeaBuilder : IDrinkBuilder
    {
        Drink objDrink;

        public TeaBuilder()
        {
            objDrink = new Drink("Tea");
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
