using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
    public interface IAdminLogsFormService
    {
        event Action evUserChoosed;
        event Action evLogChoosed;
        event Action evAllLogsPrinted;
        event Action evLogsExported;
        void ChooseUser();
        void ChooseLog();
        void PrintAllLogs();
        void ExportLogs();
    }
}
