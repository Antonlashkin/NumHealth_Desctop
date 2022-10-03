using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace NH
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Оповещение";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Medicament noshpa = new Medicament();
            Alerts.An_Hour_Before_Taking_The_Medicine("", noshpa.Get_Breakfast(), notifyIcon1);

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
