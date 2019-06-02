namespace ProjetDJ
{
    partial class Listes
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
            this.gBLocation = new System.Windows.Forms.GroupBox();
            this.dGVLocation = new System.Windows.Forms.DataGridView();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.gBAchat = new System.Windows.Forms.GroupBox();
            this.dGVAchat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixAchat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.gBLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLocation)).BeginInit();
            this.gBAchat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAchat)).BeginInit();
            this.SuspendLayout();
            // 
            // gBLocation
            // 
            this.gBLocation.Controls.Add(this.gBAchat);
            this.gBLocation.Controls.Add(this.dGVLocation);
            this.gBLocation.Location = new System.Drawing.Point(22, 12);
            this.gBLocation.Name = "gBLocation";
            this.gBLocation.Size = new System.Drawing.Size(688, 338);
            this.gBLocation.TabIndex = 0;
            this.gBLocation.TabStop = false;
            this.gBLocation.Text = "Location";
            // 
            // dGVLocation
            // 
            this.dGVLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.puissance,
            this.dimensions,
            this.masse,
            this.prixLocation,
            this.image});
            this.dGVLocation.Location = new System.Drawing.Point(18, 35);
            this.dGVLocation.Name = "dGVLocation";
            this.dGVLocation.Size = new System.Drawing.Size(645, 297);
            this.dGVLocation.TabIndex = 0;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(22, 567);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(667, 567);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmer.TabIndex = 2;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // gBAchat
            // 
            this.gBAchat.Controls.Add(this.dGVAchat);
            this.gBAchat.Location = new System.Drawing.Point(0, 0);
            this.gBAchat.Name = "gBAchat";
            this.gBAchat.Size = new System.Drawing.Size(688, 338);
            this.gBAchat.TabIndex = 3;
            this.gBAchat.TabStop = false;
            this.gBAchat.Text = "Achat";
            // 
            // dGVAchat
            // 
            this.dGVAchat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAchat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.prixAchat,
            this.dataGridViewImageColumn1});
            this.dGVAchat.Location = new System.Drawing.Point(18, 19);
            this.dGVAchat.Name = "dGVAchat";
            this.dGVAchat.Size = new System.Drawing.Size(645, 249);
            this.dGVAchat.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Puissance";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Dimensions";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Masse";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // prixAchat
            // 
            this.prixAchat.HeaderText = "Prix d\'achat";
            this.prixAchat.Name = "prixAchat";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
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
            // prixLocation
            // 
            this.prixLocation.HeaderText = "Prix de Location";
            this.prixLocation.Name = "prixLocation";
            // 
            // image
            // 
            this.image.HeaderText = "Image";
            this.image.Name = "image";
            // 
            // Listes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 602);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.gBLocation);
            this.Name = "Listes";
            this.Text = "Listes";
            this.Load += new System.EventHandler(this.Listes_Load);
            this.gBLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLocation)).EndInit();
            this.gBAchat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAchat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBLocation;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.GroupBox gBAchat;
        private System.Windows.Forms.DataGridView dGVLocation;
        private System.Windows.Forms.DataGridView dGVAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixAchat;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn puissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn masse;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixLocation;
        private System.Windows.Forms.DataGridViewImageColumn image;
    }
}