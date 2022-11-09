using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SponsorSphipApp.Views
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 17;
            timer1.Interval = 1000;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep(); 
            if(progressBar1.Value== progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                MainApp mainApp = new MainApp();
                mainApp.Show();
            }
        }
    }
}
