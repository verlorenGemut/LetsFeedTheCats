﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
    public interface IAdminLogsFormService
    {
        event Action UserChoosed;
        event Action LogChoosed;
        event Action AllLogsPrinted;
        event Action LogsExported;
        void ChooseUser();
        void ChooseLog();
        void PrintAllLogs();
        void ExportLogs();
    }
}
