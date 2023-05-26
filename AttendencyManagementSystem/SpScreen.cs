using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendencyManagementSystem
{
    public partial class SpScreen : Form
    {
        public SpScreen()
        {
            InitializeComponent();
        }

        private void SpScreen_Load(object sender, EventArgs e)
        {
            timerSpScreen.Enabled = true;
            timerSpScreen.Start();
            timerSpScreen.Interval = 1000;
            progressBar.Maximum = 10;
            timerSpScreen.Tick += new EventHandler(timerSpScreen_Tick);

             
        }

        private void timerSpScreen_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value != 10)
            {
                progressBar.Value++;
            }
            else
            {
                timerSpScreen.Stop();
                loginForm lg = new loginForm();
                lg.Show();
                this.Hide();
            }
        }
    }
}
