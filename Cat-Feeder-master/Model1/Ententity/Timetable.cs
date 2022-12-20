using System.Collections.Generic;

namespace Model.Ententity
{
    public class Timetable
    {
        private string name;
        private List<TumpleTimetable> data;
        public string Name { get => name; set => name = value; }
        internal List<TumpleTimetable> Data { get => data; set => data = value; }
        public Timetable(string name, List<TumpleTimetable> data)
        {
            this.name = name;
            this.data = data;
        }
    }
}
