using System.Collections.Generic;

namespace Model.Ententity
{
    public class Timetable
    {
        private string strName;
        private List<TumpleTimetable> listData;
        public string Name { get => strName; set => strName = value; }
        internal List<TumpleTimetable> Data { get => listData; set => listData = value; }
        public Timetable(string name, List<TumpleTimetable> data)
        {
            strName = name;
            listData = data;
        }
    }
}
