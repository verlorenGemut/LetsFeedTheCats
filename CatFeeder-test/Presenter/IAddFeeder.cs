using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface IAddFeeder : IView
    {
        public event Action evShowGoback;
        public event Action<string> evAddFeeder;

        void Activation_result_response(short activationResult);

    }
}
