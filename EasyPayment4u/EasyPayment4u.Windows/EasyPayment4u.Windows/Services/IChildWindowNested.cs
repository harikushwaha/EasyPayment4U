﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPayment4u.Windows.Services
{
    public interface IChildWindowNested
    {
        void Close();
        bool? ShowDialog();
        void SetOwner(object window);
        bool? DialogResult { get; set; }
    }
}
