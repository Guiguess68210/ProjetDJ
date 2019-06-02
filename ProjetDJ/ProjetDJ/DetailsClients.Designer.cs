namespace ProjetDJ
{
    partial class DetailsClient
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.dGVClients = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numFixe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPortable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(36, 406);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // dGVClients
            // 
            this.dGVClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.prenom,
            this.adresse,
            this.ville,
            this.codePostal,
            this.numFixe,
            this.numPortable,
            this.mail});
            this.dGVClients.Location = new System.Drawing.Point(12, 36);
            this.dGVClients.Name = "dGVClients";
            this.dGVClients.Size = new System.Drawing.Size(843, 322);
            this.dGVClients.TabIndex = 1;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            // 
            // adresse
            // 
            this.adresse.HeaderText = "Adresse";
            this.adresse.Name = "adresse";
            // 
            // ville
            // 
            this.ville.HeaderText = "Ville";
            this.ville.Name = "ville";
            // 
            // codePostal
            // 
            this.codePostal.HeaderText = "CodePostal";
            this.codePostal.Name = "codePostal";
            // 
            // numFixe
            // 
            this.numFixe.HeaderText = "Fixe";
            this.numFixe.Name = "numFixe";
            // 
            // numPortable
            // 
            this.numPortable.HeaderText = "Portable";
            this.numPortable.Name = "numPortable";
            // 
            // mail
            // 
            this.mail.HeaderText = "Mail";
            this.mail.Name = "mail";
            // 
            // DetailsClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.dGVClients);
            this.Controls.Add(this.btnRetour);
            this.Name = "DetailsClient";
            this.Text = "DetailsClient";
            this.Load += new System.EventHandler(this.DetailsClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView dGVClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFixe;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPortable;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
    }
}