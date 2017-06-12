namespace Exercice1
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tbProfession = new System.Windows.Forms.TextBox();
            this.lbprofession = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btFr = new System.Windows.Forms.Button();
            this.btEn = new System.Windows.Forms.Button();
            this.btDe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(82, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(113, 13);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Formulaire d\'inscription";
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Location = new System.Drawing.Point(27, 68);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(43, 13);
            this.lbFirstname.TabIndex = 1;
            this.lbFirstname.Text = "Prénom";
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(149, 62);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(100, 20);
            this.tbFirstname.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(149, 91);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(27, 94);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 13);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Nom";
            // 
            // tbBirthday
            // 
            this.tbBirthday.Location = new System.Drawing.Point(149, 117);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(100, 20);
            this.tbBirthday.TabIndex = 6;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(27, 120);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(96, 13);
            this.lbBirthday.TabIndex = 5;
            this.lbBirthday.Text = "Date de naissance";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(27, 146);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(31, 13);
            this.lbSex.TabIndex = 7;
            this.lbSex.Text = "Sexe";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbGender.Items.AddRange(new object[] {
            "Homme",
            "Femme",
            "Autre"});
            this.cbGender.Location = new System.Drawing.Point(149, 143);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 21);
            this.cbGender.TabIndex = 8;
            // 
            // tbProfession
            // 
            this.tbProfession.Location = new System.Drawing.Point(149, 167);
            this.tbProfession.Name = "tbProfession";
            this.tbProfession.Size = new System.Drawing.Size(100, 20);
            this.tbProfession.TabIndex = 10;
            // 
            // lbprofession
            // 
            this.lbprofession.AutoSize = true;
            this.lbprofession.Location = new System.Drawing.Point(27, 170);
            this.lbprofession.Name = "lbprofession";
            this.lbprofession.Size = new System.Drawing.Size(56, 13);
            this.lbprofession.TabIndex = 9;
            this.lbprofession.Text = "Profession";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(68, 193);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 13;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(149, 193);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 14;
            this.btSubmit.Text = "Soumettre";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btFr
            // 
            this.btFr.Location = new System.Drawing.Point(24, 25);
            this.btFr.Name = "btFr";
            this.btFr.Size = new System.Drawing.Size(75, 23);
            this.btFr.TabIndex = 15;
            this.btFr.Text = "Français";
            this.btFr.UseVisualStyleBackColor = true;
            this.btFr.Click += new System.EventHandler(this.btFr_Click);
            // 
            // btEn
            // 
            this.btEn.Location = new System.Drawing.Point(105, 25);
            this.btEn.Name = "btEn";
            this.btEn.Size = new System.Drawing.Size(75, 23);
            this.btEn.TabIndex = 16;
            this.btEn.Text = "English";
            this.btEn.UseVisualStyleBackColor = true;
            this.btEn.Click += new System.EventHandler(this.btEn_Click);
            // 
            // btDe
            // 
            this.btDe.Location = new System.Drawing.Point(186, 25);
            this.btDe.Name = "btDe";
            this.btDe.Size = new System.Drawing.Size(75, 23);
            this.btDe.TabIndex = 17;
            this.btDe.Text = "Deutsch";
            this.btDe.UseVisualStyleBackColor = true;
            this.btDe.Click += new System.EventHandler(this.btDe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.btDe);
            this.Controls.Add(this.btEn);
            this.Controls.Add(this.btFr);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.tbProfession);
            this.Controls.Add(this.lbprofession);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.tbBirthday);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbFirstname);
            this.Controls.Add(this.lbFirstname);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbBirthday;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox tbProfession;
        private System.Windows.Forms.Label lbprofession;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btFr;
        private System.Windows.Forms.Button btEn;
        private System.Windows.Forms.Button btDe;
    }
}

