using System;

namespace Model.Entity
{
    public class Time : ITime
    {
        public string strTime { get; set; }
        public int ID;

        /*public Time()
        {
            strTime = DateTime.Now.ToString("HH:mm");
        }*/
        public Time(string time) {}
        /*public string getTimeInHHMMSS()
        {
            return strTime;
        }*/

       /* public bool compareTime(Time time2)
        {
            if (strTime == time2.strTime)
                return true;
            return false;
        }*/
    }
}
