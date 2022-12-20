using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Ententity
{
    public class Customer
    {
        private string name;
        private string password;
        private string status;

        public Customer(string name, string password, string status)
        {
            this.name = name;
            this.password = password;
            this.status = status;
        }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Status { get => status; set => status = value; }
        internal List<Timetable> Timetables { get => timetables; set => timetables = value; }
        internal List<Log> Logs { get => logs; set => logs = value; }

        private List<Timetable> timetables;

        private List<Log> logs;

    }
}
