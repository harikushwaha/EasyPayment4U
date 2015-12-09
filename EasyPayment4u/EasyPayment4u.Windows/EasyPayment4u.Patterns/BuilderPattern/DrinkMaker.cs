using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Patterns.BuilderPattern
{
    public class DrinkMaker 
    {
        public void MakeDrink(IDrinkBuilder builder)
        {
            builder.AddWater();
            builder.AddPowder();
        }
    }
}
