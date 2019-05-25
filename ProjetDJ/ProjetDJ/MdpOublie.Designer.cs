namespace ProjetDJ
{
    partial class MdpOublie
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
            this.lblMdpOublie = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtCNMDP = new System.Windows.Forms.TextBox();
            this.txtNMDP = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblNewMdp = new System.Windows.Forms.Label();
            this.lblConfirmMdp = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMdpOublie
            // 
            this.lblMdpOublie.AutoSize = true;
            this.lblMdpOublie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdpOublie.Location = new System.Drawing.Point(271, 9);
            this.lblMdpOublie.Name = "lblMdpOublie";
            this.lblMdpOublie.Size = new System.Drawing.Size(306, 31);
            this.lblMdpOublie.TabIndex = 0;
            this.lblMdpOublie.Text = "Mot de passe oublié??";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(184, 93);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(138, 16);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code de confirmation:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(212, 42);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 16);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Mail:";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnRetour);
            this.gb1.Controls.Add(this.txtCode);
            this.gb1.Controls.Add(this.txtMail);
            this.gb1.Controls.Add(this.lblMail);
            this.gb1.Controls.Add(this.lblCode);
            this.gb1.Location = new System.Drawing.Point(30, 64);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(758, 182);
            this.gb1.TabIndex = 3;
            this.gb1.TabStop = false;
            this.gb1.Text = "Accès au code";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(37, 134);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(328, 92);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 4;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(247, 39);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(181, 20);
            this.txtMail.TabIndex = 3;
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.btnAnnuler);
            this.gb2.Controls.Add(this.txtCNMDP);
            this.gb2.Controls.Add(this.txtNMDP);
            this.gb2.Controls.Add(this.btnConfirm);
            this.gb2.Controls.Add(this.lblNewMdp);
            this.gb2.Controls.Add(this.lblConfirmMdp);
            this.gb2.Location = new System.Drawing.Point(30, 256);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(758, 182);
            this.gb2.TabIndex = 4;
            this.gb2.TabStop = false;
            this.gb2.Text = "Confirmation ";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(37, 140);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // txtCNMDP
            // 
            this.txtCNMDP.Location = new System.Drawing.Point(346, 101);
            this.txtCNMDP.Name = "txtCNMDP";
            this.txtCNMDP.Size = new System.Drawing.Size(100, 20);
            this.txtCNMDP.TabIndex = 5;
            // 
            // txtNMDP
            // 
            this.txtNMDP.Location = new System.Drawing.Point(346, 39);
            this.txtNMDP.Name = "txtNMDP";
            this.txtNMDP.Size = new System.Drawing.Size(100, 20);
            this.txtNMDP.TabIndex = 4;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(580, 140);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirmer";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // lblNewMdp
            // 
            this.lblNewMdp.AutoSize = true;
            this.lblNewMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewMdp.Location = new System.Drawing.Point(184, 40);
            this.lblNewMdp.Name = "lblNewMdp";
            this.lblNewMdp.Size = new System.Drawing.Size(151, 16);
            this.lblNewMdp.TabIndex = 2;
            this.lblNewMdp.Text = "Nouveau mot de passe:";
            // 
            // lblConfirmMdp
            // 
            this.lblConfirmMdp.AutoSize = true;
            this.lblConfirmMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmMdp.Location = new System.Drawing.Point(184, 89);
            this.lblConfirmMdp.Name = "lblConfirmMdp";
            this.lblConfirmMdp.Size = new System.Drawing.Size(158, 32);
            this.lblConfirmMdp.TabIndex = 1;
            this.lblConfirmMdp.Text = "Confirmation du nouveau \r\n       mot de passe:";
            // 
            // MdpOublie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.lblMdpOublie);
            this.Name = "MdpOublie";
            this.Text = "MdpOublie";
            this.Load += new System.EventHandler(this.MdpOublie_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMdpOublie;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblNewMdp;
        private System.Windows.Forms.Label lblConfirmMdp;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtCNMDP;
        private System.Windows.Forms.TextBox txtNMDP;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnAnnuler;
    }
}