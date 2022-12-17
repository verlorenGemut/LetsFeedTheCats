using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface IEditTimetable : IView
    {
        public event Action evShowGoback;
        public event Action<string> evRemoveTimestamp;
        void update_result_response(short updateResult);

        void display_timestamp_list(Timetable timetable);
    }
}
