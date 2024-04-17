using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blupi_Opener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening Speedy Blupi. This shouldn't take too long.", "BlupLauncher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProcessStartInfo thethinginquestion = new ProcessStartInfo("C:\\Program Files (x86)\\BlupLauncher\\Shortcuts for BlupLauncher\\1.lnk"); // To prevent the "Error, game not installed" popup
            Process.Start(thethinginquestion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening Speedy Blupi 2. This shouldn't take too long.", "BlupLauncher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProcessStartInfo thethinginquestion = new ProcessStartInfo("C:\\Program Files (x86)\\BlupLauncher\\Shortcuts for BlupLauncher\\2.lnk");
            Process.Start(thethinginquestion);
        }
    }
}
