using System;
using System.Collections.Generic;
using Model.Entity;
using System.Data;

namespace Model.Repository
{
    public class TimetableRepository : IRepository<Timetable>
    {
        private DataBase dataBase = new DataBase();
        public int addFeederToDatabase(Timetable timetable)
        {
            string feederID = timetable.StrFeederID;
            string timetableID = timetable.strTimetableID;
            string name = timetable.strName;
            string time = timetable.strTime;
            List<Time> timeToFeed = timetable.timeToFeed;
            string data = "('" + timetableID + "', '" + feederID + "', '" + name +"', '" + time + "')";
            if (timeToFeed != null)
            {
                foreach (Time t in timeToFeed)
                {
                    string data2 = "('" + t.strTime + "', '" + timetableID + "')";
                    string columns = "(time, timetable_id)";
                    dataBase.insertSomeData("timestamps", data2, columns);
                }
            }
            dataBase.insertData("timetable", data);
            return 0;
        }

        public void removeFeederFromDatabase(Timetable timetable)
        {
            string timetableID = timetable.strTimetableID;
            List<Time> timeToFeed = timetable.timeToFeed;
            string conditions = "timetable_id = '" + timetableID + "'";
            if (timeToFeed != null)
            {
                foreach (Time t in timeToFeed)
                {
                    string conditions2 = "timetable_id = '" + timetableID + "'";
                    dataBase.deleteData("timestamps", conditions2);
                }
            } 
            dataBase.deleteData("timetable", conditions);
        }
        public void updateFeederInDatabase(Timetable timetable, string conditions)
        {
            string FeederId = timetable.StrFeederID;
            string TimetableId = timetable.strTimetableID;
            string name = timetable.strName;
            string time = timetable.strTime;
            List<Time> timeToFeed = timetable.timeToFeed;
            string newData = "timetable_id = '" + TimetableId + "', feeder_id = '" + FeederId + "', timetable_name = '"
                + name + "', time = '"+time+"'";
            dataBase.updateData("timetable", newData, conditions);
             
            string command = "timetable_id = '" + TimetableId + "'";
            dataBase.deleteData("timestamps", command);

            if (timeToFeed != null)
            {
                foreach (Time t in timeToFeed)
                {
                    command = "('" + t.strTime + "', '" + TimetableId + "')";
                    string columns = "(time, timetable_id)";
                    dataBase.insertSomeData("timestamps", command, columns);
                }
            }

        }

        public Timetable getFeederFromDatabase(string timetableID)
        {
            DataTable table = new DataTable();
            string conditions = "timetable_id= '" + timetableID + "'";
            table = dataBase.getAllDataWhere("timetable", conditions);
            Timetable timetable = new Timetable();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var data = row.ItemArray;
                    timetable.strTimetableID = data[0].ToString();
                    timetable.StrFeederID = data[1].ToString();
                    timetable.strName = data[2].ToString();
                }
            }
            else
                return null;

            conditions = "timetable_id= '" + timetableID + "'";
            table = dataBase.getAllDataWhere("timestamps", conditions);
            List<Time> listTimesToFeed = new List<Time>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var data = row.ItemArray;
                    Time time = new Time("1");
                    time.ID = (int)data[0];
                    time.strTime = data[1].ToString();
                    listTimesToFeed.Add(time);
                }
            }
            else timetable.timeToFeed = null;
            timetable.timeToFeed = listTimesToFeed;
            return timetable;
        }

        public List<Timetable> getAllFeeders()
        {
            DataTable table = new DataTable();
            table = dataBase.getAllData("timetable");
            List<Timetable> timetableList = new List<Timetable>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var data = row.ItemArray;
                    Timetable timetable = new Timetable();
                    timetable.strTimetableID = data[0].ToString();
                    timetable.StrFeederID = data[1].ToString();
                    timetable.strName = data[2].ToString();

                    //
                    string conditions = "timetable_id= '" + timetable.strTimetableID + "'";
                    DataTable tableIn = new DataTable();
                    tableIn = dataBase.getAllDataWhere("timestamps", conditions);
                    List<Time> listTimesToFeed = new List<Time>();
                    if (tableIn.Rows.Count > 0)
                    {
                        foreach (DataRow rowIn in tableIn.Rows)
                        {
                            var dataIn = rowIn.ItemArray;
                            Time time = new Time("1");
                            time.ID = (int)data[0];
                            time.strTime = dataIn[1].ToString();
                            listTimesToFeed.Add(time);
                        }
                    }
                    else
                        timetable.timeToFeed = null;

                    timetable.timeToFeed = listTimesToFeed;
                    timetableList.Add(timetable);
                }
            }
            else
                return null;
 
            return timetableList;
        }
        public List<Timetable> getFeedersOfUser(string feederID)
        {
			DataTable table = new DataTable();
			string conditions = "feeder_id= '" + feederID + "'";
			table = dataBase.getAllDataWhere("timetable", conditions);
			List<Timetable> listTimetables = new List<Timetable>();
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					var data = row.ItemArray;
					Timetable timetable = new Timetable();
					timetable.strTimetableID = data[0].ToString();
					timetable.StrFeederID = data[1].ToString();
					timetable.strName = data[2].ToString();
					timetable.strTime = data[3].ToString();


					string conditions2 = "timetable_id= '" + timetable.strTimetableID + "'";
					DataTable tableIn = new DataTable();
					tableIn = dataBase.getAllDataWhere("timestamps", conditions2);
					List<Time> listTimesToFeed = new List<Time>();
					if (tableIn.Rows.Count > 0)
					{
						foreach (DataRow rowIn in tableIn.Rows)
						{
							var dataIn = rowIn.ItemArray;
							Time time = new Time("1");
							time.ID = Convert.ToInt32(data[0]);
							time.strTime = dataIn[1].ToString();
							listTimesToFeed.Add(time);
						}
					}
					else
                        timetable.timeToFeed = null;

					timetable.timeToFeed = listTimesToFeed;
					listTimetables.Add(timetable);
				}
			}
			else
                return null;

			return listTimetables;
        }
        /*public List<Timetable> GetAll(string id)
        {
            throw new NotImplementedException();
        }*/

    }
}
