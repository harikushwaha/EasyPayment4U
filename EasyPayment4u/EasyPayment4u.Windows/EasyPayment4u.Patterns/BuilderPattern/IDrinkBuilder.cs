using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Patterns.BuilderPattern
{
    public interface IDrinkBuilder
    {
        void AddWater();
        void AddPowder();
        Drink Drink { get; }
    }
}
