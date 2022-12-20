using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IUserTimetableView : IView
    {
        string TextOfTimeTables { get; }
        string TitleOfTimetables { get; }

        event Action evChooseTimetable;
        event Action evExportTimetable;
        event Action evImportTimetable;
        event Action evSaveTimetable;
        event Action evChooseFeed;
    }
}
