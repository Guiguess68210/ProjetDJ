namespace ProjetDJ
{
    partial class Administration
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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.dGVFactures = new System.Windows.Forms.DataGridView();
            this.idCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectifMaterielTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFactures = new System.Windows.Forms.Label();
            this.btnMateriel = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFactures)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(287, 33);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(186, 31);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Administration";
            // 
            // dGVFactures
            // 
            this.dGVFactures.AllowUserToOrderColumns = true;
            this.dGVFactures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFactures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCo,
            this.prixTotal,
            this.effectifMaterielTotal,
            this.typeCommande,
            this.idCl});
            this.dGVFactures.Location = new System.Drawing.Point(78, 145);
            this.dGVFactures.Name = "dGVFactures";
            this.dGVFactures.Size = new System.Drawing.Size(544, 150);
            this.dGVFactures.TabIndex = 1;
            // 
            // idCo
            // 
            this.idCo.HeaderText = "n°commande";
            this.idCo.Name = "idCo";
            // 
            // prixTotal
            // 
            this.prixTotal.HeaderText = "Prix";
            this.prixTotal.Name = "prixTotal";
            // 
            // effectifMaterielTotal
            // 
            this.effectifMaterielTotal.HeaderText = "Effectif Total";
            this.effectifMaterielTotal.Name = "effectifMaterielTotal";
            // 
            // typeCommande
            // 
            this.typeCommande.HeaderText = "Type de commande";
            this.typeCommande.Name = "typeCommande";
            // 
            // idCl
            // 
            this.idCl.HeaderText = "n°client";
            this.idCl.Name = "idCl";
            // 
            // lblFactures
            // 
            this.lblFactures.AutoSize = true;
            this.lblFactures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactures.Location = new System.Drawing.Point(49, 115);
            this.lblFactures.Name = "lblFactures";
            this.lblFactures.Size = new System.Drawing.Size(104, 16);
            this.lblFactures.TabIndex = 2;
            this.lblFactures.Text = "Factures clients:";
            // 
            // btnMateriel
            // 
            this.btnMateriel.Location = new System.Drawing.Point(602, 551);
            this.btnMateriel.Name = "btnMateriel";
            this.btnMateriel.Size = new System.Drawing.Size(75, 23);
            this.btnMateriel.TabIndex = 5;
            this.btnMateriel.Text = "Materiel";
            this.btnMateriel.UseVisualStyleBackColor = true;
            this.btnMateriel.Click += new System.EventHandler(this.BtnMateriel_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(78, 551);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 6;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(333, 551);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(75, 23);
            this.btnClients.TabIndex = 7;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 589);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnMateriel);
            this.Controls.Add(this.lblFactures);
            this.Controls.Add(this.dGVFactures);
            this.Controls.Add(this.lblAdmin);
            this.Name = "Administration";
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Administration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVFactures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.DataGridView dGVFactures;
        private System.Windows.Forms.Label lblFactures;
        private System.Windows.Forms.Button btnMateriel;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectifMaterielTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCl;
        private System.Windows.Forms.Button btnClients;
    }
}