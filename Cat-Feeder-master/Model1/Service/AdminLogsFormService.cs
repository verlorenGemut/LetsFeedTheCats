using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1.Service
{
    public class AdminLogsFormService : IAdminLogsFormService
    {
        public event Action evUserChoosed;
        public event Action evLogChoosed;
        public event Action evAllLogsPrinted;
        public event Action evLogsExported;
        public void ChooseUser() 
        {
            evUserChoosed?.Invoke();
        }
        public void ChooseLog() 
        {
            evLogChoosed?.Invoke();
        }
        public void PrintAllLogs() 
        {
            evAllLogsPrinted?.Invoke();
        }
        public void ExportLogs() 
        {
            evLogsExported?.Invoke();
        }
    }
}
