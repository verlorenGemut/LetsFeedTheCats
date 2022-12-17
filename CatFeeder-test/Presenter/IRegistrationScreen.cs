using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface IRegistrationScreen : IView
    {
        event Action evShowLogInScreen;
        event Action<string, string, string> evShowRegister;

        void register_result_response(short registerResult);
    }
}
