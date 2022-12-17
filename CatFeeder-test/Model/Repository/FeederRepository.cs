using System.Collections.Generic;
using Model.Entity;
using System.Data;

namespace Model.Repository
{
    public class FeederRepository : IRepository<Feeder>
    {
        private DataBase dataBase = new DataBase();
        public int addFeederToDatabase(Feeder feeder)
        {
            string userID = feeder.strUserID;
            string feederID = feeder.strFeederID;
            string timetableID = feeder.strTimetableID;
            string name = feeder.strName;
            string data = "('" + feederID + "', '" + userID + "', '" + timetableID + "', '" + name + "')";
            // string data = "('" + feederID + "', '" + userID + "', '" + timetableID + "')";
            dataBase.insertData("feeders", data);

            return 0;
        }
        public void removeFeederFromDatabase(Feeder feeder)
        {
            string feederID = feeder.strFeederID;
            string data = "feeder_id = '" + feederID + "'";
            dataBase.deleteData("feeders", data);
        }
        public void updateFeederInDatabase(Feeder feeder, string conditions)
        {

            //string User_id = feeder.strUserID;
            //tring Feeder_id = feeder.strFeederID;
            //string Timetable_id = feeder.strTimetableID;
            string name = feeder.strName;
            string data =  "feeder_name = '" + name + "'";

            dataBase.updateData("feeders", data, conditions);
        }
        //public void Save() {}
        public Feeder getFeederFromDatabase(string feederID)
        {
            DataTable table = new DataTable();
            string conditions = "feeder_id= '" + feederID + "'";
            table = dataBase.getAllDataWhere("feeders", conditions);
            Feeder feeder = new Feeder();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var data = row.ItemArray;
                    feeder.strUserID = data[0].ToString();
                    feeder.strFeederID = data[1].ToString();
                    feeder.strTimetableID = data[2].ToString();
                    feeder.strName = data[3].ToString();
                }
            }
            else
                return null;
            return feeder;
        }
        public List<Feeder> getAllFeeders()
        {
            DataTable table = new DataTable();
            table = dataBase.getAllData("feeders");
            List<Feeder> feedersList = new List<Feeder>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    Feeder feeder = new Feeder();
                    var cells = row.ItemArray;
                    feeder.strFeederID = cells[0].ToString();
                    feeder.strUserID = cells[1].ToString();
                    feeder.strTimetableID = cells[2].ToString();
                    feeder.strName = cells[3].ToString();
                    feedersList.Add(feeder);
                }
            }
            else
                return null;
            return feedersList;
        }
        public List<Feeder> getFeedersOfUser(string userID)
        {
            DataTable table = new DataTable();
            string conditions = "user_id= '" + userID + "'";
            table = dataBase.getAllDataWhere("feeders", conditions);
            List<Feeder> feedersList = new List<Feeder>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    Feeder feeder = new Feeder();
                    var cells = row.ItemArray;
                    feeder.strFeederID = cells[0].ToString();
                    feeder.strUserID = cells[1].ToString();
                    feeder.strTimetableID = cells[2].ToString();
                    feeder.strName = cells[3].ToString();
                    feedersList.Add(feeder);
                }
            }
            else
                return null;
            return feedersList;
        }
    }
}