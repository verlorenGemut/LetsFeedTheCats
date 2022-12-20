using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
    public interface IAdminTimetableService
    {
        event Action evTimetable;
        void TimetableExportAdmin();
        void TimetableImportAdmin();
        void TimetableСhoose(int timetable);
        void TimetableText(string timetableText);

    }
}
