using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface ITimetableService
    {
        void addTimetable(string currentUserID);
        short updateFeedTime(string feederID, string timetable);
    }
}
