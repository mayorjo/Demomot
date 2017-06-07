namespace StateMachineGUI
{
    partial class View
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
            this.components = new System.ComponentModel.Container();
            this.pbRemaining = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.NumericUpDown();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMoins = new System.Windows.Forms.Button();
            this.timProgress = new System.Windows.Forms.Timer(this.components);
            this.timState = new System.Windows.Forms.Timer(this.components);
            this.LbprogressValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.state)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRemaining
            // 
            this.pbRemaining.Location = new System.Drawing.Point(36, 77);
            this.pbRemaining.Name = "pbRemaining";
            this.pbRemaining.Size = new System.Drawing.Size(315, 28);
            this.pbRemaining.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etat";
            // 
            // state
            // 
            this.state.Enabled = false;
            this.state.Location = new System.Drawing.Point(75, 153);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(45, 20);
            this.state.TabIndex = 2;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(196, 140);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 43);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "Plus";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMoins
            // 
            this.btnMoins.Location = new System.Drawing.Point(196, 189);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(73, 43);
            this.btnMoins.TabIndex = 4;
            this.btnMoins.Text = "Moins";
            this.btnMoins.UseVisualStyleBackColor = true;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // timProgress
            // 
            this.timProgress.Enabled = true;
            this.timProgress.Interval = 1500;
            this.timProgress.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timState
            // 
            this.timState.Enabled = true;
            this.timState.Tick += new System.EventHandler(this.timState_Tick);
            // 
            // LbprogressValue
            // 
            this.LbprogressValue.AutoSize = true;
            this.LbprogressValue.Location = new System.Drawing.Point(166, 61);
            this.LbprogressValue.Name = "LbprogressValue";
            this.LbprogressValue.Size = new System.Drawing.Size(21, 13);
            this.LbprogressValue.TabIndex = 5;
            this.LbprogressValue.Text = "0%";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 270);
            this.Controls.Add(this.LbprogressValue);
            this.Controls.Add(this.btnMoins);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRemaining);
            this.Name = "View";
            this.Text = "StateMachine";
            ((System.ComponentModel.ISupportInitialize)(this.state)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbRemaining;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown state;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Timer timProgress;
        private System.Windows.Forms.Timer timState;
        private System.Windows.Forms.Label LbprogressValue;
    }
}

