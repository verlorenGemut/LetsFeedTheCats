﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
    public interface IAdminRegFormService
    {
        event Action evUserRegistered;

        void AddUser(string login, string password);

    }
}
