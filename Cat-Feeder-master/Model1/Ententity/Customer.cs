using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Ententity
{
    public class Customer
    {
        private string strName;
        private string strPassword;
        private string strStatus;

        public Customer(string name, string password, string status)
        {
            strName = name;
            strPassword = password;
            strStatus = status;
        }
        public string Name { get => strName; set => strName = value; }
        public string Password { get => strPassword; set => strPassword = value; }
        public string Status { get => strStatus; set => strStatus = value; }
        internal List<Timetable> Timetables { get => timetables; set => timetables = value; }
        internal List<Log> Logs { get => logs; set => logs = value; }

        private List<Timetable> timetables;

        private List<Log> logs;

    }
}
