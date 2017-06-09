namespace theorie
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
            this.buttonFrench = new System.Windows.Forms.Button();
            this.buttonEnglish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSentence = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonFrench
            // 
            this.buttonFrench.Location = new System.Drawing.Point(37, 37);
            this.buttonFrench.Name = "buttonFrench";
            this.buttonFrench.Size = new System.Drawing.Size(75, 23);
            this.buttonFrench.TabIndex = 0;
            this.buttonFrench.Text = "Français";
            this.buttonFrench.UseVisualStyleBackColor = true;
            this.buttonFrench.Click += new System.EventHandler(this.buttonFrench_Click);
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.Location = new System.Drawing.Point(171, 37);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(75, 23);
            this.buttonEnglish.TabIndex = 1;
            this.buttonEnglish.Text = "Anglais";
            this.buttonEnglish.UseVisualStyleBackColor = true;
            this.buttonEnglish.Click += new System.EventHandler(this.buttonEnglish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Internationalisation";
            // 
            // labelSentence
            // 
            this.labelSentence.AutoSize = true;
            this.labelSentence.Location = new System.Drawing.Point(34, 127);
            this.labelSentence.Name = "labelSentence";
            this.labelSentence.Size = new System.Drawing.Size(102, 13);
            this.labelSentence.TabIndex = 3;
            this.labelSentence.Text = "Exemple en français";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelSentence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEnglish);
            this.Controls.Add(this.buttonFrench);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFrench;
        private System.Windows.Forms.Button buttonEnglish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSentence;
        private System.Windows.Forms.TextBox textBox1;
    }
}

