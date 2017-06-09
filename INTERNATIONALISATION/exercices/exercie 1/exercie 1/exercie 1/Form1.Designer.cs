namespace exercie_1
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonFrench = new System.Windows.Forms.Button();
            this.buttonEnglish = new System.Windows.Forms.Button();
            this.labelSentence = new System.Windows.Forms.Label();
            this.textBoxUserAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(100, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(95, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Internationalisation";
            // 
            // buttonFrench
            // 
            this.buttonFrench.Location = new System.Drawing.Point(41, 40);
            this.buttonFrench.Name = "buttonFrench";
            this.buttonFrench.Size = new System.Drawing.Size(75, 75);
            this.buttonFrench.TabIndex = 1;
            this.buttonFrench.Text = "Français";
            this.buttonFrench.UseVisualStyleBackColor = true;
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.Location = new System.Drawing.Point(176, 40);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(75, 75);
            this.buttonEnglish.TabIndex = 2;
            this.buttonEnglish.Text = "Anglais";
            this.buttonEnglish.UseVisualStyleBackColor = true;
            // 
            // labelSentence
            // 
            this.labelSentence.AutoSize = true;
            this.labelSentence.Location = new System.Drawing.Point(14, 159);
            this.labelSentence.Name = "labelSentence";
            this.labelSentence.Size = new System.Drawing.Size(102, 13);
            this.labelSentence.TabIndex = 3;
            this.labelSentence.Text = "Exemple en français";
            // 
            // textBoxUserAnswer
            // 
            this.textBoxUserAnswer.Location = new System.Drawing.Point(141, 159);
            this.textBoxUserAnswer.Name = "textBoxUserAnswer";
            this.textBoxUserAnswer.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserAnswer.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 210);
            this.Controls.Add(this.textBoxUserAnswer);
            this.Controls.Add(this.labelSentence);
            this.Controls.Add(this.buttonEnglish);
            this.Controls.Add(this.buttonFrench);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonFrench;
        private System.Windows.Forms.Button buttonEnglish;
        private System.Windows.Forms.Label labelSentence;
        private System.Windows.Forms.TextBox textBoxUserAnswer;
    }
}

