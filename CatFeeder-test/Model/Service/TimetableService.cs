using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entity;

namespace Model.Service
{
    public class TimetableService : ITimetableService
    {
        private IRepository<Timetable> timetableRepository;

        private static Random random = new Random();

       /* public TimetableService(IRepository<Timetable> timetableRepository)
        {
            this.timetableRepository = timetableRepository;
        }*/

        public void addTimetable(string currentUserID)
        {
            Timetable timetable = new Timetable(currentUserID, "timetable name", getRandomString(10),"9:00" );
            timetableRepository.addFeederToDatabase(timetable);

        }

        public static string getRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public short updateFeedTime(string currentFeederID, string timetable)
        {
            if (timetable == "")
                return 0;

            Timetable newTimetable = new Timetable(currentFeederID,"name_time",getRandomString(5),timetable);
            timetableRepository.addFeederToDatabase(newTimetable);
            return 1;
        }

    }
}
