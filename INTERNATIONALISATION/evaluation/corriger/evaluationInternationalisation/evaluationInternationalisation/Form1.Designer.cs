namespace evaluationInternationalisation
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btReset = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.lbZip = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.gbPersonal = new System.Windows.Forms.GroupBox();
            this.lbNickname = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbConfirm = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.gbPublic = new System.Windows.Forms.GroupBox();
            this.gbPassword = new System.Windows.Forms.GroupBox();
            this.btFr = new System.Windows.Forms.Button();
            this.btEn = new System.Windows.Forms.Button();
            this.gbPersonal.SuspendLayout();
            this.gbPublic.SuspendLayout();
            this.gbPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(85, 376);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 0;
            this.btReset.Text = "réinitialiser";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(273, 376);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 1;
            this.btSubmit.Text = "Soumettre";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(160, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(113, 13);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Formulaire d\'inscription";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(17, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 13);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Nom";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(109, 18);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(242, 20);
            this.tbName.TabIndex = 4;
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(109, 44);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(242, 20);
            this.tbFirstname.TabIndex = 6;
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Location = new System.Drawing.Point(17, 47);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(43, 13);
            this.lbFirstname.TabIndex = 5;
            this.lbFirstname.Text = "Prénom";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(109, 70);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(171, 20);
            this.tbAddress.TabIndex = 8;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(17, 73);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 13);
            this.lbAddress.TabIndex = 7;
            this.lbAddress.Text = "Adresse";
            // 
            // tbZip
            // 
            this.tbZip.Location = new System.Drawing.Point(317, 70);
            this.tbZip.Name = "tbZip";
            this.tbZip.Size = new System.Drawing.Size(34, 20);
            this.tbZip.TabIndex = 10;
            // 
            // lbZip
            // 
            this.lbZip.AutoSize = true;
            this.lbZip.Location = new System.Drawing.Point(286, 73);
            this.lbZip.Name = "lbZip";
            this.lbZip.Size = new System.Drawing.Size(25, 13);
            this.lbZip.TabIndex = 9;
            this.lbZip.Text = "NIP";
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(266, 93);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(85, 20);
            this.tbCountry.TabIndex = 14;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(212, 96);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(30, 13);
            this.lbCountry.TabIndex = 13;
            this.lbCountry.Text = "Pays";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(109, 93);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(97, 20);
            this.tbCity.TabIndex = 12;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(17, 96);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(26, 13);
            this.lbCity.TabIndex = 11;
            this.lbCity.Text = "Ville";
            // 
            // gbPersonal
            // 
            this.gbPersonal.Controls.Add(this.tbCountry);
            this.gbPersonal.Controls.Add(this.lbCountry);
            this.gbPersonal.Controls.Add(this.tbCity);
            this.gbPersonal.Controls.Add(this.lbCity);
            this.gbPersonal.Controls.Add(this.tbZip);
            this.gbPersonal.Controls.Add(this.lbZip);
            this.gbPersonal.Controls.Add(this.tbAddress);
            this.gbPersonal.Controls.Add(this.lbAddress);
            this.gbPersonal.Controls.Add(this.tbFirstname);
            this.gbPersonal.Controls.Add(this.lbFirstname);
            this.gbPersonal.Controls.Add(this.tbName);
            this.gbPersonal.Controls.Add(this.lbName);
            this.gbPersonal.Location = new System.Drawing.Point(32, 43);
            this.gbPersonal.Name = "gbPersonal";
            this.gbPersonal.Size = new System.Drawing.Size(366, 130);
            this.gbPersonal.TabIndex = 15;
            this.gbPersonal.TabStop = false;
            this.gbPersonal.Text = "Informations personnelles";
            // 
            // lbNickname
            // 
            this.lbNickname.AutoSize = true;
            this.lbNickname.Location = new System.Drawing.Point(14, 21);
            this.lbNickname.Name = "lbNickname";
            this.lbNickname.Size = new System.Drawing.Size(43, 13);
            this.lbNickname.TabIndex = 16;
            this.lbNickname.Text = "Pseudo";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(14, 45);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(67, 13);
            this.lbMail.TabIndex = 17;
            this.lbMail.Text = "Adresse Mail";
            // 
            // tbNickname
            // 
            this.tbNickname.Location = new System.Drawing.Point(109, 18);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(239, 20);
            this.tbNickname.TabIndex = 15;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(109, 42);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(239, 20);
            this.tbMail.TabIndex = 18;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(14, 27);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 13);
            this.lbPassword.TabIndex = 19;
            this.lbPassword.Text = "mot de passe";
            // 
            // lbConfirm
            // 
            this.lbConfirm.AutoSize = true;
            this.lbConfirm.Location = new System.Drawing.Point(14, 49);
            this.lbConfirm.Name = "lbConfirm";
            this.lbConfirm.Size = new System.Drawing.Size(50, 13);
            this.lbConfirm.TabIndex = 20;
            this.lbConfirm.Text = "confirmer";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(109, 24);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(249, 20);
            this.tbPassword.TabIndex = 21;
            // 
            // tbConfirm
            // 
            this.tbConfirm.Location = new System.Drawing.Point(109, 46);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.Size = new System.Drawing.Size(249, 20);
            this.tbConfirm.TabIndex = 22;
            // 
            // gbPublic
            // 
            this.gbPublic.Controls.Add(this.tbMail);
            this.gbPublic.Controls.Add(this.tbNickname);
            this.gbPublic.Controls.Add(this.lbMail);
            this.gbPublic.Controls.Add(this.lbNickname);
            this.gbPublic.Location = new System.Drawing.Point(32, 193);
            this.gbPublic.Name = "gbPublic";
            this.gbPublic.Size = new System.Drawing.Size(365, 70);
            this.gbPublic.TabIndex = 23;
            this.gbPublic.TabStop = false;
            this.gbPublic.Text = "Informations publiques";
            // 
            // gbPassword
            // 
            this.gbPassword.Controls.Add(this.tbConfirm);
            this.gbPassword.Controls.Add(this.tbPassword);
            this.gbPassword.Controls.Add(this.lbConfirm);
            this.gbPassword.Controls.Add(this.lbPassword);
            this.gbPassword.Location = new System.Drawing.Point(32, 269);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Size = new System.Drawing.Size(365, 76);
            this.gbPassword.TabIndex = 24;
            this.gbPassword.TabStop = false;
            this.gbPassword.Text = "Mot de passe";
            // 
            // btFr
            // 
            this.btFr.Location = new System.Drawing.Point(351, 7);
            this.btFr.Name = "btFr";
            this.btFr.Size = new System.Drawing.Size(30, 30);
            this.btFr.TabIndex = 25;
            this.btFr.Text = "fr";
            this.btFr.UseVisualStyleBackColor = true;
            this.btFr.Click += new System.EventHandler(this.button3_Click);
            // 
            // btEn
            // 
            this.btEn.Location = new System.Drawing.Point(387, 7);
            this.btEn.Name = "btEn";
            this.btEn.Size = new System.Drawing.Size(30, 30);
            this.btEn.TabIndex = 26;
            this.btEn.Text = "en";
            this.btEn.UseVisualStyleBackColor = true;
            this.btEn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 411);
            this.Controls.Add(this.btEn);
            this.Controls.Add(this.btFr);
            this.Controls.Add(this.gbPassword);
            this.Controls.Add(this.gbPublic);
            this.Controls.Add(this.gbPersonal);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.btReset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbPersonal.ResumeLayout(false);
            this.gbPersonal.PerformLayout();
            this.gbPublic.ResumeLayout(false);
            this.gbPublic.PerformLayout();
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.Label lbZip;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.GroupBox gbPersonal;
        private System.Windows.Forms.Label lbNickname;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbConfirm;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.GroupBox gbPublic;
        private System.Windows.Forms.GroupBox gbPassword;
        private System.Windows.Forms.Button btFr;
        private System.Windows.Forms.Button btEn;
    }
}

