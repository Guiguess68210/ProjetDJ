namespace ProjetDJ
{
    partial class DétailsCommande
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
            this.cbInstal = new System.Windows.Forms.CheckBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.gBLocation = new System.Windows.Forms.GroupBox();
            this.dGVMateriel = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVLocation = new System.Windows.Forms.DataGridView();
            this.dateDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demandeInstallation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectifMateriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBAchat = new System.Windows.Forms.GroupBox();
            this.dGVMateriel2 = new System.Windows.Forms.DataGridView();
            this.dGVAchat = new System.Windows.Forms.DataGridView();
            this.dateAchat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demandeLivraison = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectifMaterielTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBLivraison = new System.Windows.Forms.CheckBox();
            this.lblDetailsComm = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMateriel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLocation)).BeginInit();
            this.gBAchat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMateriel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAchat)).BeginInit();
            this.SuspendLayout();
            // 
            // cbInstal
            // 
            this.cbInstal.AutoSize = true;
            this.cbInstal.Location = new System.Drawing.Point(16, 266);
            this.cbInstal.Name = "cbInstal";
            this.cbInstal.Size = new System.Drawing.Size(76, 17);
            this.cbInstal.TabIndex = 0;
            this.cbInstal.Text = "Installation";
            this.cbInstal.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(663, 421);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(348, 421);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(36, 421);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 6;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // gBLocation
            // 
            this.gBLocation.Controls.Add(this.dGVMateriel);
            this.gBLocation.Controls.Add(this.dGVLocation);
            this.gBLocation.Controls.Add(this.cbInstal);
            this.gBLocation.Location = new System.Drawing.Point(36, 70);
            this.gBLocation.Name = "gBLocation";
            this.gBLocation.Size = new System.Drawing.Size(724, 306);
            this.gBLocation.TabIndex = 9;
            this.gBLocation.TabStop = false;
            this.gBLocation.Text = "Location";
            // 
            // dGVMateriel
            // 
            this.dGVMateriel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMateriel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.effectif});
            this.dGVMateriel.Location = new System.Drawing.Point(62, 19);
            this.dGVMateriel.Name = "dGVMateriel";
            this.dGVMateriel.Size = new System.Drawing.Size(243, 122);
            this.dGVMateriel.TabIndex = 2;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // effectif
            // 
            this.effectif.HeaderText = "Effectif";
            this.effectif.Name = "effectif";
            // 
            // dGVLocation
            // 
            this.dGVLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDebut,
            this.dateFin,
            this.demandeInstallation,
            this.effectifMateriel,
            this.prixTotal});
            this.dGVLocation.Location = new System.Drawing.Point(62, 147);
            this.dGVLocation.Name = "dGVLocation";
            this.dGVLocation.Size = new System.Drawing.Size(543, 79);
            this.dGVLocation.TabIndex = 1;
            // 
            // dateDebut
            // 
            this.dateDebut.HeaderText = "Date de début";
            this.dateDebut.Name = "dateDebut";
            // 
            // dateFin
            // 
            this.dateFin.HeaderText = "Date de fin";
            this.dateFin.Name = "dateFin";
            // 
            // demandeInstallation
            // 
            this.demandeInstallation.HeaderText = "Demande d\'installation";
            this.demandeInstallation.Name = "demandeInstallation";
            // 
            // effectifMateriel
            // 
            this.effectifMateriel.HeaderText = "Effectif total";
            this.effectifMateriel.Name = "effectifMateriel";
            // 
            // prixTotal
            // 
            this.prixTotal.HeaderText = "Prix total";
            this.prixTotal.Name = "prixTotal";
            // 
            // gBAchat
            // 
            this.gBAchat.Controls.Add(this.dGVMateriel2);
            this.gBAchat.Controls.Add(this.dGVAchat);
            this.gBAchat.Controls.Add(this.cBLivraison);
            this.gBAchat.Location = new System.Drawing.Point(36, 70);
            this.gBAchat.Name = "gBAchat";
            this.gBAchat.Size = new System.Drawing.Size(724, 306);
            this.gBAchat.TabIndex = 10;
            this.gBAchat.TabStop = false;
            this.gBAchat.Text = "Achat";
            // 
            // dGVMateriel2
            // 
            this.dGVMateriel2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMateriel2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dGVMateriel2.Location = new System.Drawing.Point(62, 28);
            this.dGVMateriel2.Name = "dGVMateriel2";
            this.dGVMateriel2.Size = new System.Drawing.Size(243, 122);
            this.dGVMateriel2.TabIndex = 3;
            // 
            // dGVAchat
            // 
            this.dGVAchat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAchat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateAchat,
            this.demandeLivraison,
            this.effectifMaterielTotal,
            this.dataGridViewTextBoxColumn1});
            this.dGVAchat.Location = new System.Drawing.Point(62, 156);
            this.dGVAchat.Name = "dGVAchat";
            this.dGVAchat.Size = new System.Drawing.Size(445, 98);
            this.dGVAchat.TabIndex = 2;
            // 
            // dateAchat
            // 
            this.dateAchat.HeaderText = "Date d\'achat";
            this.dateAchat.Name = "dateAchat";
            // 
            // demandeLivraison
            // 
            this.demandeLivraison.HeaderText = "Demande de livraison";
            this.demandeLivraison.Name = "demandeLivraison";
            // 
            // effectifMaterielTotal
            // 
            this.effectifMaterielTotal.HeaderText = "Effectif total";
            this.effectifMaterielTotal.Name = "effectifMaterielTotal";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Prix total";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // cBLivraison
            // 
            this.cBLivraison.AutoSize = true;
            this.cBLivraison.Location = new System.Drawing.Point(16, 283);
            this.cBLivraison.Name = "cBLivraison";
            this.cBLivraison.Size = new System.Drawing.Size(68, 17);
            this.cBLivraison.TabIndex = 1;
            this.cBLivraison.Text = "Livraison";
            this.cBLivraison.UseVisualStyleBackColor = true;
            // 
            // lblDetailsComm
            // 
            this.lblDetailsComm.AutoSize = true;
            this.lblDetailsComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsComm.Location = new System.Drawing.Point(255, 21);
            this.lblDetailsComm.Name = "lblDetailsComm";
            this.lblDetailsComm.Size = new System.Drawing.Size(238, 31);
            this.lblDetailsComm.TabIndex = 11;
            this.lblDetailsComm.Text = "Détails commande";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom du matériel";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Effectif";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // DétailsCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblDetailsComm);
            this.Controls.Add(this.gBAchat);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.gBLocation);
            this.Name = "DétailsCommande";
            this.Text = "DétailsCommande";
            this.Load += new System.EventHandler(this.DétailsCommande_Load);
            this.gBLocation.ResumeLayout(false);
            this.gBLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMateriel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLocation)).EndInit();
            this.gBAchat.ResumeLayout(false);
            this.gBAchat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMateriel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAchat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbInstal;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.GroupBox gBLocation;
        private System.Windows.Forms.GroupBox gBAchat;
        private System.Windows.Forms.Label lblDetailsComm;
        private System.Windows.Forms.CheckBox cBLivraison;
        private System.Windows.Forms.DataGridView dGVMateriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectif;
        private System.Windows.Forms.DataGridView dGVLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn demandeInstallation;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectifMateriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixTotal;
        private System.Windows.Forms.DataGridView dGVMateriel2;
        private System.Windows.Forms.DataGridView dGVAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn demandeLivraison;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectifMaterielTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}