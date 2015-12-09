using EasyPayment4u.Patterns.BuilderPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrinkBuilder builder = null;
            DrinkMaker maker = new DrinkMaker();///Director

            ///Make Tee
            builder = new TeaBuilder();
            maker.MakeDrink(builder);

            Console.WriteLine(builder.Drink.ToString());

            ///Make Tee
            builder = new CoffeeBuilder();
            maker.MakeDrink(builder);

            Console.WriteLine(builder.Drink.ToString());

            Console.ReadKey();

        }
    }
}
