using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface IHomeAdmin : IView
    {
        public event Action evShowLogOut;
        public event Action evShowFeederIDiist;


    }
}
