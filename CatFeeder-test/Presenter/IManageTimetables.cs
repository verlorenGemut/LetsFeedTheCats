using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface IManageTimetables : IView
    {
        public event Action evShowGoback;
        public event Action<string> evShowEditTimetable;
        public event Action<string> evRemoveTimetable;
        public event Action evAddTimetable;
        void display_timetable_list(List<Timetable> timetablelist);
    }
}
