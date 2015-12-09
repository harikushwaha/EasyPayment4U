using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Patterns.BuilderPattern
{
    public class Drink
    {
        private readonly string _label;
        public Drink(string label)
        {
            this._label = label;
        }
        public override string ToString()
        {
            return this._label;
        }
    }
}
