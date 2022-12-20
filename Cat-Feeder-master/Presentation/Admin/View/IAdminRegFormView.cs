using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IAdminRegFormView : IView
    {
        string password { get; }
        string login { get; }
        event Action<string, string> AddUser;
    }
}
