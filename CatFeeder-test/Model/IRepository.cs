using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IRepository<T> where T : class
    {
        int addFeederToDatabase(T obj);
        void removeFeederFromDatabase(T obj);
        void updateFeederInDatabase(T obj, string conditions);

        List<T> getFeedersOfUser(string id);
        List<T> getAllFeeders();
        T getFeederFromDatabase(string id);
    }
}

