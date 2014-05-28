namespace AppliDrago
{
    partial class Chargement
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
            this.label1 = new System.Windows.Forms.Label();
            this.barChargement = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelPourcentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Requête en cour de traitement...";
            // 
            // barChargement
            // 
            this.barChargement.Location = new System.Drawing.Point(12, 36);
            this.barChargement.MarqueeAnimationSpeed = 1;
            this.barChargement.Name = "barChargement";
            this.barChargement.Size = new System.Drawing.Size(157, 23);
            this.barChargement.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barChargement.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // labelPourcentage
            // 
            this.labelPourcentage.AutoSize = true;
            this.labelPourcentage.Location = new System.Drawing.Point(49, 62);
            this.labelPourcentage.Name = "labelPourcentage";
            this.labelPourcentage.Size = new System.Drawing.Size(35, 13);
            this.labelPourcentage.TabIndex = 2;
            this.labelPourcentage.Text = "label2";
            // 
            // Chargement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 85);
            this.Controls.Add(this.labelPourcentage);
            this.Controls.Add(this.barChargement);
            this.Controls.Add(this.label1);
            this.Name = "Chargement";
            this.Load += new System.EventHandler(this.Chargement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar barChargement;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelPourcentage;
    }
}