using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicThreading 
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-"); 

            Thread ThreadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread ThreadB = new Thread(new ThreadStart(MyThreadClass.Thread1));

            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            lblStatus.Text = "-End of Thread-";
            Console.WriteLine("-End of Thread-"); 
        }
    }
}