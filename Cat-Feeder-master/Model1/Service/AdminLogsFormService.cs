using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1.Service
{
    public class AdminLogsFormService : IAdminLogsFormService
    {
        public event Action UserChoosed;
        public event Action LogChoosed;
        public event Action AllLogsPrinted;
        public event Action LogsExported;
        public void ChooseUser() 
        {
            //код


            UserChoosed?.Invoke();
        }
        public void ChooseLog() 
        {
            //код


            LogChoosed?.Invoke();
        }
        public void PrintAllLogs() 
        {
            //код


            AllLogsPrinted?.Invoke();
        }
        public void ExportLogs() 
        {
            //код


            LogsExported?.Invoke();
        }
    }
}
