using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
    public interface IRepository<T> where T : class
    {
        int add(T obj);
        void update(T obj);
        void remove(int id);
        void save();
        T find(string name);
        IEnumerable<T> getAll();
    }
}
