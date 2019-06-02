namespace ProjetDJ
{
    partial class DetailsMateriel
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
            this.dGVMateriel = new System.Windows.Forms.DataGridView();
            this.idM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixAchat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAjout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMateriel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(36, 405);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // dGVMateriel
            // 
            this.dGVMateriel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMateriel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idM,
            this.nom,
            this.puissance,
            this.dimensions,
            this.masse,
            this.stock,
            this.prixAchat,
            this.prixLocation,
            this.prixVente,
            this.image});
            this.dGVMateriel.Location = new System.Drawing.Point(12, 25);
            this.dGVMateriel.Name = "dGVMateriel";
            this.dGVMateriel.Size = new System.Drawing.Size(1041, 344);
            this.dGVMateriel.TabIndex = 5;
            // 
            // idM
            // 
            this.idM.HeaderText = "n°materiel";
            this.idM.Name = "idM";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // puissance
            // 
            this.puissance.HeaderText = "Puissance";
            this.puissance.Name = "puissance";
            // 
            // dimensions
            // 
            this.dimensions.HeaderText = "Dimensions";
            this.dimensions.Name = "dimensions";
            // 
            // masse
            // 
            this.masse.HeaderText = "Masse";
            this.masse.Name = "masse";
            // 
            // stock
            // 
            this.stock.HeaderText = "En stock";
            this.stock.Name = "stock";
            // 
            // prixAchat
            // 
            this.prixAchat.HeaderText = "Prix d\'achat";
            this.prixAchat.Name = "prixAchat";
            // 
            // prixLocation
            // 
            this.prixLocation.HeaderText = "Prix de location";
            this.prixLocation.Name = "prixLocation";
            // 
            // prixVente
            // 
            this.prixVente.HeaderText = "Prix de vente";
            this.prixVente.Name = "prixVente";
            // 
            // image
            // 
            this.image.HeaderText = "Image";
            this.image.Name = "image";
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(871, 405);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(68, 23);
            this.btnAjout.TabIndex = 6;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // DetailsMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 450);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.dGVMateriel);
            this.Controls.Add(this.btnRetour);
            this.Name = "DetailsMateriel";
            this.Text = "DetailsMateriel";
            this.Load += new System.EventHandler(this.DetailsMateriel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVMateriel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView dGVMateriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idM;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn puissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn masse;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVente;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.Button btnAjout;
    }
}