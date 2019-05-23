namespace ProjetDJ
{
    partial class Inscription
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
            this.btnInscription = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblnumF = new System.Windows.Forms.Label();
            this.lblnumP = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblMDP = new System.Windows.Forms.Label();
            this.lblConfirmMDP = new System.Windows.Forms.Label();
            this.lblInscriptio = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNumPort = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.txtNumFixe = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtCMDP = new System.Windows.Forms.TextBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInscription
            // 
            this.btnInscription.Location = new System.Drawing.Point(571, 345);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(75, 23);
            this.btnInscription.TabIndex = 0;
            this.btnInscription.Text = "Valider";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.BtnInscription_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(207, 74);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(40, 16);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom:";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(207, 99);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(58, 16);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom:";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.Location = new System.Drawing.Point(207, 127);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(65, 16);
            this.lblAdresse.TabIndex = 3;
            this.lblAdresse.Text = "Adresse: ";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(207, 186);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(37, 16);
            this.lblVille.TabIndex = 4;
            this.lblVille.Text = "Ville:";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.Location = new System.Drawing.Point(207, 157);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(84, 16);
            this.lblCP.TabIndex = 5;
            this.lblCP.Text = "Code postal:";
            // 
            // lblnumF
            // 
            this.lblnumF.AutoSize = true;
            this.lblnumF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumF.Location = new System.Drawing.Point(207, 216);
            this.lblnumF.Name = "lblnumF";
            this.lblnumF.Size = new System.Drawing.Size(61, 16);
            this.lblnumF.TabIndex = 6;
            this.lblnumF.Text = "numFixe:";
            // 
            // lblnumP
            // 
            this.lblnumP.AutoSize = true;
            this.lblnumP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumP.Location = new System.Drawing.Point(203, 247);
            this.lblnumP.Name = "lblnumP";
            this.lblnumP.Size = new System.Drawing.Size(87, 16);
            this.lblnumP.TabIndex = 7;
            this.lblnumP.Text = "numPortable:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(207, 274);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 16);
            this.lblMail.TabIndex = 8;
            this.lblMail.Text = "Mail:";
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDP.Location = new System.Drawing.Point(207, 304);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(93, 16);
            this.lblMDP.TabIndex = 9;
            this.lblMDP.Text = "Mot de passe:";
            // 
            // lblConfirmMDP
            // 
            this.lblConfirmMDP.AutoSize = true;
            this.lblConfirmMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmMDP.Location = new System.Drawing.Point(207, 333);
            this.lblConfirmMDP.Name = "lblConfirmMDP";
            this.lblConfirmMDP.Size = new System.Drawing.Size(103, 32);
            this.lblConfirmMDP.TabIndex = 10;
            this.lblConfirmMDP.Text = "Confirmation du \r\n  mot de passe:";
            // 
            // lblInscriptio
            // 
            this.lblInscriptio.AutoSize = true;
            this.lblInscriptio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscriptio.Location = new System.Drawing.Point(296, 9);
            this.lblInscriptio.Name = "lblInscriptio";
            this.lblInscriptio.Size = new System.Drawing.Size(288, 29);
            this.lblInscriptio.TabIndex = 11;
            this.lblInscriptio.Text = "Formulaire d\'inscription";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(326, 73);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 12;
            // 
            // txtNumPort
            // 
            this.txtNumPort.Location = new System.Drawing.Point(326, 246);
            this.txtNumPort.Name = "txtNumPort";
            this.txtNumPort.Size = new System.Drawing.Size(100, 20);
            this.txtNumPort.TabIndex = 13;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(326, 273);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(176, 20);
            this.txtMail.TabIndex = 14;
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(326, 303);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.Size = new System.Drawing.Size(100, 20);
            this.txtMDP.TabIndex = 15;
            // 
            // txtNumFixe
            // 
            this.txtNumFixe.Location = new System.Drawing.Point(326, 215);
            this.txtNumFixe.Name = "txtNumFixe";
            this.txtNumFixe.Size = new System.Drawing.Size(100, 20);
            this.txtNumFixe.TabIndex = 16;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(326, 185);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 20);
            this.txtVille.TabIndex = 17;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(326, 156);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 20);
            this.txtCP.TabIndex = 18;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(326, 126);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(176, 20);
            this.txtAdresse.TabIndex = 19;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(326, 98);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 20;
            // 
            // txtCMDP
            // 
            this.txtCMDP.Location = new System.Drawing.Point(326, 345);
            this.txtCMDP.Name = "txtCMDP";
            this.txtCMDP.Size = new System.Drawing.Size(100, 20);
            this.txtCMDP.TabIndex = 21;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(71, 345);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 22;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.txtCMDP);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtNumFixe);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtNumPort);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblInscriptio);
            this.Controls.Add(this.lblConfirmMDP);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblnumP);
            this.Controls.Add(this.lblnumF);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnInscription);
            this.Name = "Inscription";
            this.Text = "Inscription";
            this.Load += new System.EventHandler(this.Inscription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblnumF;
        private System.Windows.Forms.Label lblnumP;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.Label lblConfirmMDP;
        private System.Windows.Forms.Label lblInscriptio;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNumPort;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.TextBox txtNumFixe;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtCMDP;
        private System.Windows.Forms.Button btnRetour;
    }
}