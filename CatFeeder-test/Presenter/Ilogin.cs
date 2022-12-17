using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    

    public interface ILogIn : IView
    {

        event Action<string, string> evShowLogIn;
        event Action evShowRegisterScreen;

    }
}
