namespace AccesDonnees1
{
    partial class LireUnClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nClientlbl = new System.Windows.Forms.Label();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.lblChiffreDAffaire = new System.Windows.Forms.Label();
            this.lblRSClient = new System.Windows.Forms.Label();
            this.lblCAClient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nClientlbl
            // 
            this.nClientlbl.AutoSize = true;
            this.nClientlbl.Location = new System.Drawing.Point(76, 93);
            this.nClientlbl.Name = "nClientlbl";
            this.nClientlbl.Size = new System.Drawing.Size(48, 13);
            this.nClientlbl.TabIndex = 0;
            this.nClientlbl.Text = "N° Client";
            // 
            // txtIdClient
            // 
            this.txtIdClient.Location = new System.Drawing.Point(184, 90);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(100, 20);
            this.txtIdClient.TabIndex = 1;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(345, 87);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(76, 153);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(84, 13);
            this.lblRaisonSociale.TabIndex = 3;
            this.lblRaisonSociale.Text = "Raison Sociale :";
            // 
            // lblChiffreDAffaire
            // 
            this.lblChiffreDAffaire.AutoSize = true;
            this.lblChiffreDAffaire.Location = new System.Drawing.Point(76, 210);
            this.lblChiffreDAffaire.Name = "lblChiffreDAffaire";
            this.lblChiffreDAffaire.Size = new System.Drawing.Size(88, 13);
            this.lblChiffreDAffaire.TabIndex = 4;
            this.lblChiffreDAffaire.Text = "Chiffre d\'affaires :";
            // 
            // lblRSClient
            // 
            this.lblRSClient.AutoSize = true;
            this.lblRSClient.Location = new System.Drawing.Point(217, 153);
            this.lblRSClient.Name = "lblRSClient";
            this.lblRSClient.Size = new System.Drawing.Size(40, 13);
            this.lblRSClient.TabIndex = 5;
            this.lblRSClient.Text = "rs_client";
            // 
            // lblCAClient
            // 
            this.lblCAClient.AutoSize = true;
            this.lblCAClient.Location = new System.Drawing.Point(217, 210);
            this.lblCAClient.Name = "lblCAClient";
            this.lblCAClient.Size = new System.Drawing.Size(44, 13);
            this.lblCAClient.TabIndex = 6;
            this.lblCAClient.Text = "ca_client";
            // 
            // LireUnClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCAClient);
            this.Controls.Add(this.lblRSClient);
            this.Controls.Add(this.lblChiffreDAffaire);
            this.Controls.Add(this.lblRaisonSociale);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtIdClient);
            this.Controls.Add(this.nClientlbl);
            this.Name = "LireUnClient";
            this.Text = "LireUnClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nClientlbl;
        private System.Windows.Forms.TextBox txtIdClient;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label lblRaisonSociale;
        private System.Windows.Forms.Label lblChiffreDAffaire;
        private System.Windows.Forms.Label lblRSClient;
        private System.Windows.Forms.Label lblCAClient;
    }
}