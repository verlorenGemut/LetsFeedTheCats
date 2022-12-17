using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class Timetable
    {
        public Timetable() { }

        public Timetable(string feederID, string name, string timetableID,string time)
		{
            StrFeederID = feederID;
            strName = name;
            strTimetableID = timetableID;
            strTime = time;
		}
        public List<Time> timeToFeed { get; set; }
        public string StrFeederID { get; set; }
        public string strName { get; set; }
        public string strTimetableID { get; set; }
        public string strTime { get; set; }

    }
}
