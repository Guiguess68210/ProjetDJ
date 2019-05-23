namespace ProjetDJ
{
    partial class Accueil
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMDP = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lkLblMdpOublie = new System.Windows.Forms.LinkLabel();
            this.lblAccueil = new System.Windows.Forms.Label();
            this.btnInscription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(152, 162);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(130, 20);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Nom d\'utilisateur:";
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDP.Location = new System.Drawing.Point(172, 208);
            this.lblMDP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(109, 20);
            this.lblMDP.TabIndex = 1;
            this.lblMDP.Text = "Mot de passe:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(290, 160);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(132, 22);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.Text = "votre mail";
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(290, 208);
            this.txtMDP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.Size = new System.Drawing.Size(132, 22);
            this.txtMDP.TabIndex = 3;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(402, 287);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(100, 28);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click);
            // 
            // lkLblMdpOublie
            // 
            this.lkLblMdpOublie.AutoSize = true;
            this.lkLblMdpOublie.Location = new System.Drawing.Point(242, 293);
            this.lkLblMdpOublie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lkLblMdpOublie.Name = "lkLblMdpOublie";
            this.lkLblMdpOublie.Size = new System.Drawing.Size(137, 16);
            this.lkLblMdpOublie.TabIndex = 5;
            this.lkLblMdpOublie.TabStop = true;
            this.lkLblMdpOublie.Text = "Mot de passe oublié?";
            this.lkLblMdpOublie.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkLblMdpOublie_LinkClicked);
            // 
            // lblAccueil
            // 
            this.lblAccueil.BackColor = System.Drawing.SystemColors.Control;
            this.lblAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccueil.Location = new System.Drawing.Point(13, 27);
            this.lblAccueil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccueil.Name = "lblAccueil";
            this.lblAccueil.Size = new System.Drawing.Size(722, 50);
            this.lblAccueil.TabIndex = 6;
            this.lblAccueil.Text = "Bienvenue dans l\'interface de location et vente de matériels de DJ\r\n";
            // 
            // btnInscription
            // 
            this.btnInscription.Location = new System.Drawing.Point(131, 287);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(82, 29);
            this.btnInscription.TabIndex = 7;
            this.btnInscription.Text = "S\'inscrire";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.BtnInscription_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(751, 548);
            this.Controls.Add(this.btnInscription);
            this.Controls.Add(this.lblAccueil);
            this.Controls.Add(this.lkLblMdpOublie);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.lblLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.LinkLabel lkLblMdpOublie;
        private System.Windows.Forms.Label lblAccueil;
        private System.Windows.Forms.Button btnInscription;
    }
}

