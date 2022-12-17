using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface IEditFeeder : IView
    {
        public event Action evShowGoback;
        event Action<string> evShowUpdate;
        event Action<string> evShowTimeUpdate;


        void update_result_response(short updateResult);
        void update_result_response1(short updateResult);
    }
}
