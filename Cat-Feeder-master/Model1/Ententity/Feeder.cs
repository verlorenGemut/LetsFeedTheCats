using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Ententity
{


    public abstract class Feeder
    {
        private string strName;
        public string Name
        {
            get { return strName; }
            set => strName = value;
        }
        private int amountOfFood;
        public int Value
        {
            get { return amountOfFood; }
            set { amountOfFood = value; }
        }

       

        private List<Note> notes;

        public List<Note> Notes { get => notes; set => notes = value; }
        

        private Timetable timetable;
        public Timetable Timetable { get => timetable; set => timetable = value; }

    }
    class DispenserFeeder: Feeder
    {
        public DispenserFeeder()
        {
            Console.WriteLine("Dispenser Feeder");
        }
    }

    class SensorFeeder: Feeder
    {
        public SensorFeeder()
        {
            Console.WriteLine("Sensor Feeder");
        }
    }

    abstract class Developer
    {   
        abstract public Feeder Create();
    }
}
