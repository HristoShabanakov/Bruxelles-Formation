namespace Pong
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
            this.panelAirDeJeu = new System.Windows.Forms.Panel();
            this.pictureBoxBalle = new System.Windows.Forms.PictureBox();
            this.pictureBoxPalette2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPalette1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelAirDeJeu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAirDeJeu
            // 
            this.panelAirDeJeu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAirDeJeu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelAirDeJeu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAirDeJeu.Controls.Add(this.pictureBoxBalle);
            this.panelAirDeJeu.Controls.Add(this.pictureBoxPalette2);
            this.panelAirDeJeu.Controls.Add(this.pictureBoxPalette1);
            this.panelAirDeJeu.Location = new System.Drawing.Point(12, 58);
            this.panelAirDeJeu.Name = "panelAirDeJeu";
            this.panelAirDeJeu.Size = new System.Drawing.Size(788, 358);
            this.panelAirDeJeu.TabIndex = 0;
            this.panelAirDeJeu.SizeChanged += new System.EventHandler(this.panelAirDeJeu_SizeChanged);
            this.panelAirDeJeu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelAirDeJeu_MouseMove);
            // 
            // pictureBoxBalle
            // 
            this.pictureBoxBalle.Image = global::Pong.Properties.Resources.Tennis_Ball_PNG_Image;
            this.pictureBoxBalle.Location = new System.Drawing.Point(297, 107);
            this.pictureBoxBalle.Name = "pictureBoxBalle";
            this.pictureBoxBalle.Size = new System.Drawing.Size(38, 38);
            this.pictureBoxBalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBalle.TabIndex = 2;
            this.pictureBoxBalle.TabStop = false;
            // 
            // pictureBoxPalette2
            // 
            this.pictureBoxPalette2.BackColor = System.Drawing.Color.White;
            this.pictureBoxPalette2.Location = new System.Drawing.Point(529, 93);
            this.pictureBoxPalette2.Name = "pictureBoxPalette2";
            this.pictureBoxPalette2.Size = new System.Drawing.Size(10, 69);
            this.pictureBoxPalette2.TabIndex = 1;
            this.pictureBoxPalette2.TabStop = false;
            // 
            // pictureBoxPalette1
            // 
            this.pictureBoxPalette1.BackColor = System.Drawing.Color.White;
            this.pictureBoxPalette1.Location = new System.Drawing.Point(47, 107);
            this.pictureBoxPalette1.Name = "pictureBoxPalette1";
            this.pictureBoxPalette1.Size = new System.Drawing.Size(10, 69);
            this.pictureBoxPalette1.TabIndex = 0;
            this.pictureBoxPalette1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 428);
            this.Controls.Add(this.panelAirDeJeu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelAirDeJeu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAirDeJeu;
        private System.Windows.Forms.PictureBox pictureBoxBalle;
        private System.Windows.Forms.PictureBox pictureBoxPalette2;
        private System.Windows.Forms.PictureBox pictureBoxPalette1;
        private System.Windows.Forms.Timer timer;
    }
}

