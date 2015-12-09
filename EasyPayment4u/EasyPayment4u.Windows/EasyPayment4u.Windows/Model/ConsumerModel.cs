using EasyPayment4u.Windows.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Windows.Model
{
    public class ConsumerModel : BaseModel
    {

        private int _ConsumerID;
        private string _FirstName;
        private string _MiddleName;
        private string _LastName;
        private int? _OrderID;
        private decimal? _MobileNumber;

        public int ConsumerID
        {
            get { return _ConsumerID; }
            set
            {
                _ConsumerID = value;
                base.SetPropertyChanged("ConsumerID");
            }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                _FirstName = value;
                base.SetPropertyChanged("FirstName");
            }
        }
        public string MiddleName
        {
            get { return _MiddleName; }
            set
            {
                _MiddleName = value;
                base.SetPropertyChanged("MiddleName");
            }
        }
        public string LastName
        {
            get { return _LastName; }
            set
            {
                _LastName = value;
                base.SetPropertyChanged("LastName");
            }
        }
        public int? OrderID
        {
            get { return _OrderID; }
            set
            {
                _OrderID = value;
                base.SetPropertyChanged("OrderID");
            }
        }
        public decimal? MobileNumber
        {
            get { return _MobileNumber; }
            set
            {
                _MobileNumber = value;
                base.SetPropertyChanged("MobileNumber");
            }
        }
    }
}
