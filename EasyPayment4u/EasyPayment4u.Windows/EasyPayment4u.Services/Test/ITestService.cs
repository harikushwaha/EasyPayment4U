using EasyPayment4u.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Services
{
    //http://web.archive.org/web/20150404154203/https://www.remondo.net/repository-pattern-example-csharp/
    public interface ITestService
    {

       Test GetTestBuId(int i);
       List<Test> GetTestData();
    }
}
