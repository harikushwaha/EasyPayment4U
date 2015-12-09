using EasyPayment4u.Windows.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Windows.ViewModel
{
    public interface ITextViewModel
    {
        string LabelContnet { get; set; }
        IChildWindow ChildWindow { get; set; }
    }
}
