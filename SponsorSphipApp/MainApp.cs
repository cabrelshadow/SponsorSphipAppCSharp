using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SponsorSphipApp.Views;

namespace SponsorSphipApp
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //pourcharger les autres formulaires dans le mainpanel

        public void LoadForm(object Form)
        {
            if (this.MainPanelForm.Controls.Count > 0)
                this.MainPanelForm.Controls.RemoveAt(0);

            Form formulaire = Form as Form;
            formulaire.TopLevel = false;
            formulaire.Dock = DockStyle.Fill;
            this.MainPanelForm.Controls.Add(formulaire);
            this.MainPanelForm.Tag = formulaire;
            formulaire.Show();

        }

        private void MainApp_Load(object sender, EventArgs e)
        {

        }

        private void AddMembers_Click(object sender, EventArgs e)
        {
            LoadForm(new Filleuls());
        }

        private void ShowMembers_Click(object sender, EventArgs e)
        {
            LoadForm(new ListMembers());
        }

        private void SponsorShipEvent_Click(object sender, EventArgs e)
        {
            LoadForm(new SponsorShipEvent());
        }

        private void BtnParrain_Click(object sender, EventArgs e)
        {
            LoadForm(new Parrains());
        }
    }
}
