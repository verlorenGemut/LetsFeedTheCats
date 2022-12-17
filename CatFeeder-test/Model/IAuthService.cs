using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IAuthService
    {
        short logIn(string username, string password);
        short register(string username, string password, string confirmPassword);
    }
}
