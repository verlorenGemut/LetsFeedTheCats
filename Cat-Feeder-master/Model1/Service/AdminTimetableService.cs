using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1.Service
{
    public class AdminTimetableService: IAdminTimetableService
    {
        public event Action evTimetable;
        public void TimetableExportAdmin()
        {
            evTimetable?.Invoke();
        }
        public void TimetableImportAdmin()
        {
            evTimetable?.Invoke();
        }
        public void TimetableСhoose(int timetable)
        {
            evTimetable?.Invoke();
        }
        public void TimetableText(string timetableText)
        {
            evTimetable?.Invoke();
        }
    }
}
