namespace PongWithClass
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxPalette1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBalle = new System.Windows.Forms.PictureBox();
            this.timerBall = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxPalette2 = new System.Windows.Forms.PictureBox();
            this.timerPalette2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBoxPalette2);
            this.panel1.Controls.Add(this.pictureBoxPalette1);
            this.panel1.Controls.Add(this.pictureBoxBalle);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 286);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxPalette1
            // 
            this.pictureBoxPalette1.BackColor = System.Drawing.Color.White;
            this.pictureBoxPalette1.Location = new System.Drawing.Point(18, 88);
            this.pictureBoxPalette1.Name = "pictureBoxPalette1";
            this.pictureBoxPalette1.Size = new System.Drawing.Size(10, 61);
            this.pictureBoxPalette1.TabIndex = 2;
            this.pictureBoxPalette1.TabStop = false;
            // 
            // pictureBoxBalle
            // 
            this.pictureBoxBalle.BackColor = System.Drawing.Color.White;
            this.pictureBoxBalle.Location = new System.Drawing.Point(221, 88);
            this.pictureBoxBalle.Name = "pictureBoxBalle";
            this.pictureBoxBalle.Size = new System.Drawing.Size(25, 27);
            this.pictureBoxBalle.TabIndex = 0;
            this.pictureBoxBalle.TabStop = false;
            // 
            // timerBall
            // 
            this.timerBall.Enabled = true;
            this.timerBall.Interval = 50;
            this.timerBall.Tick += new System.EventHandler(this.timerBall_Tick);
            // 
            // pictureBoxPalette2
            // 
            this.pictureBoxPalette2.BackColor = System.Drawing.Color.White;
            this.pictureBoxPalette2.Location = new System.Drawing.Point(536, 88);
            this.pictureBoxPalette2.Name = "pictureBoxPalette2";
            this.pictureBoxPalette2.Size = new System.Drawing.Size(10, 61);
            this.pictureBoxPalette2.TabIndex = 3;
            this.pictureBoxPalette2.TabStop = false;
            // 
            // timerPalette2
            // 
            this.timerPalette2.Enabled = true;
            this.timerPalette2.Tick += new System.EventHandler(this.timerPalette2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 341);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerBall;
        private System.Windows.Forms.PictureBox pictureBoxBalle;
        private System.Windows.Forms.PictureBox pictureBoxPalette1;
        private System.Windows.Forms.PictureBox pictureBoxPalette2;
        private System.Windows.Forms.Timer timerPalette2;
    }
}

