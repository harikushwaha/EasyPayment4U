using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EasyPayment4u.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    //[ServiceBehavior(InstanceContextMode=InstanceContextMode.PerCall)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class TestService : ITestService
    {
        int _number;
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public int IncrementNumber()
        {
            _number = _number + 1;
            return _number;
        }



        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }
    }
}
