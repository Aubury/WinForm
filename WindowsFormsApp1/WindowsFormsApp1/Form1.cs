using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myProcess.StartInfo = new System.Diagnostics.ProcessStartInfo("calc.exe");
          
        }

        private void Start_Click(object sender, EventArgs e)
        {
            myProcess.Start();
           
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            myProcess.CloseMainWindow();
            myProcess.Close();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }
    }
}
