namespace ProjetDJ
{
    partial class Dates
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
            this.lblDate = new System.Windows.Forms.Label();
            this.gBLocation = new System.Windows.Forms.GroupBox();
            this.gBAchat = new System.Windows.Forms.GroupBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dTPDebut = new System.Windows.Forms.DateTimePicker();
            this.dTPFin = new System.Windows.Forms.DateTimePicker();
            this.dTPAchat = new System.Windows.Forms.DateTimePicker();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateAchat = new System.Windows.Forms.Label();
            this.gBLocation.SuspendLayout();
            this.gBAchat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(345, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(86, 31);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Dates";
            // 
            // gBLocation
            // 
            this.gBLocation.Controls.Add(this.lblDateDebut);
            this.gBLocation.Controls.Add(this.lblDateFin);
            this.gBLocation.Controls.Add(this.dTPFin);
            this.gBLocation.Controls.Add(this.dTPDebut);
            this.gBLocation.Location = new System.Drawing.Point(12, 94);
            this.gBLocation.Name = "gBLocation";
            this.gBLocation.Size = new System.Drawing.Size(776, 100);
            this.gBLocation.TabIndex = 1;
            this.gBLocation.TabStop = false;
            this.gBLocation.Text = "Location";
            // 
            // gBAchat
            // 
            this.gBAchat.Controls.Add(this.lblDateAchat);
            this.gBAchat.Controls.Add(this.dTPAchat);
            this.gBAchat.Location = new System.Drawing.Point(12, 94);
            this.gBAchat.Name = "gBAchat";
            this.gBAchat.Size = new System.Drawing.Size(776, 100);
            this.gBAchat.TabIndex = 2;
            this.gBAchat.TabStop = false;
            this.gBAchat.Text = "Achat";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(12, 225);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(323, 225);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(713, 225);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dTPDebut
            // 
            this.dTPDebut.Location = new System.Drawing.Point(124, 47);
            this.dTPDebut.Name = "dTPDebut";
            this.dTPDebut.Size = new System.Drawing.Size(200, 20);
            this.dTPDebut.TabIndex = 0;
            // 
            // dTPFin
            // 
            this.dTPFin.Location = new System.Drawing.Point(535, 47);
            this.dTPFin.Name = "dTPFin";
            this.dTPFin.Size = new System.Drawing.Size(200, 20);
            this.dTPFin.TabIndex = 1;
            // 
            // dTPAchat
            // 
            this.dTPAchat.Location = new System.Drawing.Point(311, 43);
            this.dTPAchat.Name = "dTPAchat";
            this.dTPAchat.Size = new System.Drawing.Size(200, 20);
            this.dTPAchat.TabIndex = 0;
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.Location = new System.Drawing.Point(454, 47);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(75, 16);
            this.lblDateFin.TabIndex = 2;
            this.lblDateFin.Text = "Date de fin:";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.Location = new System.Drawing.Point(22, 47);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(96, 16);
            this.lblDateDebut.TabIndex = 3;
            this.lblDateDebut.Text = "Date de début:";
            // 
            // lblDateAchat
            // 
            this.lblDateAchat.AutoSize = true;
            this.lblDateAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAchat.Location = new System.Drawing.Point(218, 43);
            this.lblDateAchat.Name = "lblDateAchat";
            this.lblDateAchat.Size = new System.Drawing.Size(87, 16);
            this.lblDateAchat.TabIndex = 3;
            this.lblDateAchat.Text = "Date d\'achat:";
            // 
            // Dates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 276);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.gBAchat);
            this.Controls.Add(this.gBLocation);
            this.Controls.Add(this.lblDate);
            this.Name = "Dates";
            this.Text = "Dates";
            this.Load += new System.EventHandler(this.Dates_Load);
            this.gBLocation.ResumeLayout(false);
            this.gBLocation.PerformLayout();
            this.gBAchat.ResumeLayout(false);
            this.gBAchat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox gBLocation;
        private System.Windows.Forms.GroupBox gBAchat;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DateTimePicker dTPFin;
        private System.Windows.Forms.DateTimePicker dTPDebut;
        private System.Windows.Forms.DateTimePicker dTPAchat;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateAchat;
    }
}