using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NH
{
    internal class Alerts
    {
        public void Out_Of_Pills(string Name)
        {
            Console.WriteLine("У вас закончился препарат " + Name + "! Стоит купит еще.");
        }

        public void An_Hour_Before_Taking_The_Medicine(string Name, DateTime Reception_Time)
        {
            Console.WriteLine("Через 1 час, в " + Reception_Time + " нужно будет принять " + Name + "!");
        }

    }
}
