using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IAdminTimetableView : IView
    {
        event Action<int> evTimetableСhoose;      // Параметр это номер расписания
        event Action evTimetableExportAdmin;
        event Action evTimetableImportAdmin;
        event Action<string> evTimetableText;
    }
}
