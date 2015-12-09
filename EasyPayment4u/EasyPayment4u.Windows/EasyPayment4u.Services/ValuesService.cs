using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Services
{
    public class ValuesService : IValuesService
    {
        private Dictionary<int, string> _values;

        public ValuesService()
        {
            _values = new Dictionary<int, string>
                      {
                          {1, "Value 1"},
                          {2, "Value 2"},
                          {3, "Value 3"},
                          {4, "Value 4"},
                          {5, "Value 5"},
                      };
        }

        private int GetNextId()
        {
            return _values.Keys.Max() + 1;
        }

        public int Create(string value)
        {
            var id = GetNextId();
            _values.Add(id, value);
            return id;
        }

        public string Update(int id, string value)
        {
            _values[id] = value;
            return Get(id);
        }

        public void Delete(int id)
        {
            _values.Remove(id);
        }

        public IDictionary<int, string> GetAll()
        {
            return _values;
        }

        public string Get(int id)
        {
            return _values[id];
        }

    }
}
