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
            Thread thread = new Thread(delegate ()
            {

            });
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("pill.ico"));
            notifyIcon1.Text = "Some text";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Дед, выпей таблеткуб а то получишь по жопе! ";
            notifyIcon1.BalloonTipText = "Click here or see details";
            notifyIcon1.ShowBalloonTip(100);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
