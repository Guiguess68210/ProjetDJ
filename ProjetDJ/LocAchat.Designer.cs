namespace ProjetDJ
{
    partial class LocAchat
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
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnAchat = new System.Windows.Forms.Button();
            this.lblChoix = new System.Windows.Forms.Label();
            this.btnDeco = new System.Windows.Forms.Button();
            this.btnCommande = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLocation
            // 
            this.btnLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation.Location = new System.Drawing.Point(130, 123);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(156, 62);
            this.btnLocation.TabIndex = 0;
            this.btnLocation.Text = "Location";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.BtnLocation_Click);
            // 
            // btnAchat
            // 
            this.btnAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAchat.Location = new System.Drawing.Point(428, 123);
            this.btnAchat.Name = "btnAchat";
            this.btnAchat.Size = new System.Drawing.Size(168, 62);
            this.btnAchat.TabIndex = 1;
            this.btnAchat.Text = "Achat";
            this.btnAchat.UseVisualStyleBackColor = true;
            this.btnAchat.Click += new System.EventHandler(this.BtnAchat_Click);
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoix.Location = new System.Drawing.Point(224, 30);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(268, 31);
            this.lblChoix.TabIndex = 2;
            this.lblChoix.Text = "Quel est votre choix?";
            // 
            // btnDeco
            // 
            this.btnDeco.Location = new System.Drawing.Point(702, 12);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(86, 23);
            this.btnDeco.TabIndex = 3;
            this.btnDeco.Text = "Déconnexion";
            this.btnDeco.UseVisualStyleBackColor = true;
            this.btnDeco.Click += new System.EventHandler(this.BtnDeco_Click);
            // 
            // btnCommande
            // 
            this.btnCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommande.Location = new System.Drawing.Point(278, 254);
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Size = new System.Drawing.Size(156, 62);
            this.btnCommande.TabIndex = 4;
            this.btnCommande.Text = "Vos commandes";
            this.btnCommande.UseVisualStyleBackColor = true;
            this.btnCommande.Click += new System.EventHandler(this.BtnCommande_Click);
            // 
            // LocAchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCommande);
            this.Controls.Add(this.btnDeco);
            this.Controls.Add(this.lblChoix);
            this.Controls.Add(this.btnAchat);
            this.Controls.Add(this.btnLocation);
            this.Name = "LocAchat";
            this.Text = "LocAchat";
            this.Load += new System.EventHandler(this.LocAchat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnAchat;
        private System.Windows.Forms.Label lblChoix;
        private System.Windows.Forms.Button btnDeco;
        private System.Windows.Forms.Button btnCommande;
    }
}