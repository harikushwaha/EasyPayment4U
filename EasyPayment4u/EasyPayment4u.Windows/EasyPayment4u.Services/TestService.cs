using EasyPayment4u.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyPayment4u.Data;
namespace EasyPayment4u.Services
{
    public class TestService : ITestService
    {
        private readonly IRepository<Test> _testItemRepository;
        public TestService(IRepository<Test> testItemRepository)
        {
            this._testItemRepository = testItemRepository;
        }
        public virtual EasyPayment4u.Data.Test GetTestBuId(int testId)
        {
            if (testId == 0) return null;
            return _testItemRepository.GetById(testId);
        }



        public List<Test> GetTestData()
        {
            return _testItemRepository.Table.ToList();
        }
    }
}
