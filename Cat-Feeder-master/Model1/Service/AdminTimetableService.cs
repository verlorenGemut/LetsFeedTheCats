using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1.Service
{
    public class AdminTimetableService: IAdminTimetableService
    {
        public event Action TimetableEvent;
        public void TimetableExportAdmin()
        {
            //код

            TimetableEvent?.Invoke();
        }
        public void TimetableImportAdmin()
        {
            //код

            TimetableEvent?.Invoke();
        }
        public void TimetableСhoose(int timetable)
        {
            //код

            TimetableEvent?.Invoke();
        }
        public void TimetableText(string timetableText)
        {
            //код

            TimetableEvent?.Invoke();
        }
    }
}
