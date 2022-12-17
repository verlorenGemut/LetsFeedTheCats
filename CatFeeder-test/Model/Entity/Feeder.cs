namespace Model.Entity
{
    public class Feeder
    {
        public Feeder(string ID, string name)
        {
            strFeederID = ID;
            strName = name;
            strTimetableID = null;
            strUserID = null;
        }
        public Feeder() {}

        public string strUserID;
        public string strFeederID;
        public string strTimetableID;
        public string strName;
    }
}
