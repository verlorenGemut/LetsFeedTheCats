using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IAdminTimetableView : IView
    {
        event Action<int> TimetableСhoose;      // Параметр это номер расписания
        event Action TimetableExportAdmin;
        event Action TimetableImportAdmin;
        event Action<string> TimetableText;
       // event Action TimetableText;//ВЫВОД РАСПИСАНИЯ ДЛЯ АДМИНА
    }
}
