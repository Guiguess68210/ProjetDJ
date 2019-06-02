namespace ProjetDJ
{
    partial class VosCommandes
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
            this.lblCommande = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.dGVCommande = new System.Windows.Forms.DataGridView();
            this.idCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbMateriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixMateriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCommande
            // 
            this.lblCommande.AutoSize = true;
            this.lblCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommande.Location = new System.Drawing.Point(12, 26);
            this.lblCommande.Name = "lblCommande";
            this.lblCommande.Size = new System.Drawing.Size(272, 29);
            this.lblCommande.TabIndex = 0;
            this.lblCommande.Text = "Commandes du client ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 1;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(441, 26);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(0, 29);
            this.lblPrenom.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(600, 23);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(23, 31);
            this.lbl.TabIndex = 3;
            this.lbl.Text = ":";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(17, 394);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(290, 26);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(0, 29);
            this.lblNom.TabIndex = 5;
            // 
            // dGVCommande
            // 
            this.dGVCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCo,
            this.typeCommande,
            this.nbMateriel,
            this.prixMateriel});
            this.dGVCommande.Location = new System.Drawing.Point(114, 113);
            this.dGVCommande.Name = "dGVCommande";
            this.dGVCommande.Size = new System.Drawing.Size(444, 249);
            this.dGVCommande.TabIndex = 6;
            // 
            // idCo
            // 
            this.idCo.HeaderText = "n°Commande";
            this.idCo.Name = "idCo";
            // 
            // typeCommande
            // 
            this.typeCommande.HeaderText = "Type de Commande";
            this.typeCommande.Name = "typeCommande";
            // 
            // nbMateriel
            // 
            this.nbMateriel.HeaderText = "Effectif total";
            this.nbMateriel.Name = "nbMateriel";
            // 
            // prixMateriel
            // 
            this.prixMateriel.HeaderText = "Prix du Matériel";
            this.prixMateriel.Name = "prixMateriel";
            // 
            // VosCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.dGVCommande);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCommande);
            this.Name = "VosCommandes";
            this.Text = "VosCommandes";
            this.Load += new System.EventHandler(this.VosCommandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCommande;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.DataGridView dGVCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbMateriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixMateriel;
    }
}