using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Services
{
    public interface IValuesService
    {
        int Create(string value);
        string Update(int id, string value);
        void Delete(int id);

        IDictionary<int, string> GetAll();
        string Get(int id);
    }
}
