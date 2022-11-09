namespace SponsorSphipApp
{
    partial class MainApp
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SponsorSphip = new System.Windows.Forms.Label();
            this.SponsorShipEvent = new System.Windows.Forms.Button();
            this.ShowMembers = new System.Windows.Forms.Button();
            this.AddMembers = new System.Windows.Forms.Button();
            this.MainPanelForm = new System.Windows.Forms.Panel();
            this.BtnParrain = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(32)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.SponsorShipEvent);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnParrain);
            this.panel1.Controls.Add(this.ShowMembers);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.AddMembers);
            this.panel1.Controls.Add(this.SponsorSphip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 54);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 472);
            this.panel2.TabIndex = 1;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.Red;
            this.CloseBtn.Location = new System.Drawing.Point(1024, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(22, 22);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SponsorSphip
            // 
            this.SponsorSphip.AutoSize = true;
            this.SponsorSphip.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SponsorSphip.ForeColor = System.Drawing.Color.White;
            this.SponsorSphip.Location = new System.Drawing.Point(807, 9);
            this.SponsorSphip.Name = "SponsorSphip";
            this.SponsorSphip.Size = new System.Drawing.Size(184, 31);
            this.SponsorSphip.TabIndex = 0;
            this.SponsorSphip.Text = "SponsorSphip";
            // 
            // SponsorShipEvent
            // 
            this.SponsorShipEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SponsorShipEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SponsorShipEvent.ForeColor = System.Drawing.Color.White;
            this.SponsorShipEvent.Location = new System.Drawing.Point(432, 8);
            this.SponsorShipEvent.Name = "SponsorShipEvent";
            this.SponsorShipEvent.Size = new System.Drawing.Size(164, 40);
            this.SponsorShipEvent.TabIndex = 0;
            this.SponsorShipEvent.Text = "Start SponsorSphip";
            this.SponsorShipEvent.UseVisualStyleBackColor = true;
            this.SponsorShipEvent.Click += new System.EventHandler(this.SponsorShipEvent_Click);
            // 
            // ShowMembers
            // 
            this.ShowMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMembers.ForeColor = System.Drawing.Color.White;
            this.ShowMembers.Location = new System.Drawing.Point(292, 8);
            this.ShowMembers.Name = "ShowMembers";
            this.ShowMembers.Size = new System.Drawing.Size(134, 40);
            this.ShowMembers.TabIndex = 0;
            this.ShowMembers.Text = "Show Members";
            this.ShowMembers.UseVisualStyleBackColor = true;
            this.ShowMembers.Click += new System.EventHandler(this.ShowMembers_Click);
            // 
            // AddMembers
            // 
            this.AddMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMembers.ForeColor = System.Drawing.Color.White;
            this.AddMembers.Location = new System.Drawing.Point(12, 8);
            this.AddMembers.Name = "AddMembers";
            this.AddMembers.Size = new System.Drawing.Size(134, 40);
            this.AddMembers.TabIndex = 0;
            this.AddMembers.Text = "Filleuls";
            this.AddMembers.UseVisualStyleBackColor = true;
            this.AddMembers.Click += new System.EventHandler(this.AddMembers_Click);
            // 
            // MainPanelForm
            // 
            this.MainPanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelForm.Location = new System.Drawing.Point(0, 54);
            this.MainPanelForm.Name = "MainPanelForm";
            this.MainPanelForm.Size = new System.Drawing.Size(1049, 464);
            this.MainPanelForm.TabIndex = 1;
            // 
            // BtnParrain
            // 
            this.BtnParrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnParrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnParrain.ForeColor = System.Drawing.Color.White;
            this.BtnParrain.Location = new System.Drawing.Point(152, 8);
            this.BtnParrain.Name = "BtnParrain";
            this.BtnParrain.Size = new System.Drawing.Size(134, 40);
            this.BtnParrain.TabIndex = 0;
            this.BtnParrain.Text = "Parrains";
            this.BtnParrain.UseVisualStyleBackColor = true;
            this.BtnParrain.Click += new System.EventHandler(this.BtnParrain_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 518);
            this.Controls.Add(this.MainPanelForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label SponsorSphip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SponsorShipEvent;
        private System.Windows.Forms.Button ShowMembers;
        private System.Windows.Forms.Button AddMembers;
        private System.Windows.Forms.Panel MainPanelForm;
        private System.Windows.Forms.Button BtnParrain;
    }
}

