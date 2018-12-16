namespace Lotto
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
            this.buttonGenererValeursAleatoires = new System.Windows.Forms.Button();
            this.panelGrille = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonGenererValeursAleatoires
            // 
            this.buttonGenererValeursAleatoires.Location = new System.Drawing.Point(26, 30);
            this.buttonGenererValeursAleatoires.Name = "buttonGenererValeursAleatoires";
            this.buttonGenererValeursAleatoires.Size = new System.Drawing.Size(75, 23);
            this.buttonGenererValeursAleatoires.TabIndex = 0;
            this.buttonGenererValeursAleatoires.Text = "Generer";
            this.buttonGenererValeursAleatoires.UseVisualStyleBackColor = true;
            this.buttonGenererValeursAleatoires.Click += new System.EventHandler(this.buttonGenererValeursAleatoires_Click);
            // 
            // panelGrille
            // 
            this.panelGrille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrille.Location = new System.Drawing.Point(152, 12);
            this.panelGrille.Name = "panelGrille";
            this.panelGrille.Size = new System.Drawing.Size(354, 372);
            this.panelGrille.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 396);
            this.Controls.Add(this.panelGrille);
            this.Controls.Add(this.buttonGenererValeursAleatoires);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenererValeursAleatoires;
        private System.Windows.Forms.Panel panelGrille;
    }
}

