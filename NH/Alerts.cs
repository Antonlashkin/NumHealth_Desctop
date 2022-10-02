using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace NH
{
    internal class Alerts
    {
        public void Out_Of_Pills(string Name)
        {
            Console.WriteLine("У вас закончился препарат " + Name + "! Стоит купит еще.");
        }

        static public void  An_Hour_Before_Taking_The_Medicine(string Name, DateTime Reception_Time, NotifyIcon notifyIcon1)
        {
            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("pill.ico"));
            notifyIcon1.Text = "Some text";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Дед, выпей таблеткуб а то получишь по жопе! ";
            notifyIcon1.BalloonTipText = "Click here or see details";
            notifyIcon1.ShowBalloonTip(100);
        }

    }
}
