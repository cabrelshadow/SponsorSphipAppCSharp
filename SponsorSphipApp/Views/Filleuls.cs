using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SponsorSphipApp.View.Db;

namespace SponsorSphipApp.Views
{
    public partial class Filleuls : Form
    {
        public Filleuls()
        {
            InitializeComponent();
        }

        private void Addmembers_Load(object sender, EventArgs e)
        {
            string[] facuty = { "TIC-1", "TIC-RSI-2", "TIC-PAM-2", "PREPA-1", "PREPA-2" };
            cbFaculy.DataSource = facuty;
            cbFaculy.SelectedIndex=-1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            string fullname = Fullname.Text;
            string phone =Txtphone.Text;
            string email = TxtEmail.Text;
            string facuty= cbFaculy.Text.ToString();

            try
            {
                string query = "INSERT INTO FILLEULS(FULLNAME,PHONE,EMAIL,FACULTY)VALUES('" + fullname +"','"+ phone +"','" + email +"','"+ facuty +"')";
                DbConnect db = new DbConnect();
                db.Execute(query);
                MessageBox.Show("insertion effectuer avec success","insertion",MessageBoxButtons.OK,MessageBoxIcon.Information);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          


        }
    }
}
