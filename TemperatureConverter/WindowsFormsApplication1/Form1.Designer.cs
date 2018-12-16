namespace WindowsFormsApplication1
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.comboBoxInputUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxOutputUnit = new System.Windows.Forms.ComboBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(49, 63);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxInputUnit
            // 
            this.comboBoxInputUnit.FormattingEnabled = true;
            this.comboBoxInputUnit.Items.AddRange(new object[] {
            "C",
            "K",
            "F"});
            this.comboBoxInputUnit.Location = new System.Drawing.Point(155, 63);
            this.comboBoxInputUnit.Name = "comboBoxInputUnit";
            this.comboBoxInputUnit.Size = new System.Drawing.Size(50, 21);
            this.comboBoxInputUnit.TabIndex = 1;
            this.comboBoxInputUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxOutputUnit
            // 
            this.comboBoxOutputUnit.FormattingEnabled = true;
            this.comboBoxOutputUnit.Items.AddRange(new object[] {
            "C",
            "K",
            "F"});
            this.comboBoxOutputUnit.Location = new System.Drawing.Point(155, 90);
            this.comboBoxOutputUnit.Name = "comboBoxOutputUnit";
            this.comboBoxOutputUnit.Size = new System.Drawing.Size(50, 21);
            this.comboBoxOutputUnit.TabIndex = 3;
            this.comboBoxOutputUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(114, 98);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(13, 13);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "0";
            this.labelOutput.SizeChanged += new System.EventHandler(this.labelOutput_SizeChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 133);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.comboBoxOutputUnit);
            this.Controls.Add(this.comboBoxInputUnit);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Convertisseur de température";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ComboBox comboBoxInputUnit;
        private System.Windows.Forms.ComboBox comboBoxOutputUnit;
        private System.Windows.Forms.Label labelOutput;
    }
}

