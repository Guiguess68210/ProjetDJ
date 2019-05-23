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
            this.lblFactures = new System.Windows.Forms.Label();
            this.lblGM = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFactures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(279, 42);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(186, 31);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Administration";
            // 
            // dGVFactures
            // 
            this.dGVFactures.AllowUserToOrderColumns = true;
            this.dGVFactures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFactures.Location = new System.Drawing.Point(52, 146);
            this.dGVFactures.Name = "dGVFactures";
            this.dGVFactures.Size = new System.Drawing.Size(692, 150);
            this.dGVFactures.TabIndex = 1;
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
            // lblGM
            // 
            this.lblGM.AutoSize = true;
            this.lblGM.Location = new System.Drawing.Point(49, 326);
            this.lblGM.Name = "lblGM";
            this.lblGM.Size = new System.Drawing.Size(100, 13);
            this.lblGM.TabIndex = 3;
            this.lblGM.Text = "Gestion du matériel:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(692, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(611, 551);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 23);
            this.btnAjout.TabIndex = 5;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(78, 551);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 6;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblGM);
            this.Controls.Add(this.lblFactures);
            this.Controls.Add(this.dGVFactures);
            this.Controls.Add(this.lblAdmin);
            this.Name = "Administration";
            this.Text = "Administration";
            ((System.ComponentModel.ISupportInitialize)(this.dGVFactures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.DataGridView dGVFactures;
        private System.Windows.Forms.Label lblFactures;
        private System.Windows.Forms.Label lblGM;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnRetour;
    }
}