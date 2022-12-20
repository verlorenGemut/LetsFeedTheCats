using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Ententity
{
    public class Log
    {
        private string occasion;
        private DateTime time;

 
        public DateTime Time { get => time; set => time = value; }
        public string Occasion { get => occasion; set => occasion = value; }

        public Log(string occassion, DateTime time)
        {
            this.Occasion = occassion;
            this.time = time;
        }
    }
}
