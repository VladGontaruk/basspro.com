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

namespace ProjectsManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Users\VLADISALV\Documents\Visual Studio 2017\Projects\ProjectsManager\Ripper\bin\Debug\Ripper.exe");
            startInfo.Arguments = "Hello World";
            System.Diagnostics.Process.Start(startInfo);
        }
    }
}
