namespace AppliDrago
{
    partial class Appli3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appli3));
            this.pictureBoxReturn = new System.Windows.Forms.PictureBox();
            this.pictureBoxQuit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClasse = new System.Windows.Forms.TextBox();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxSellPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxStat1 = new System.Windows.Forms.TextBox();
            this.textBoxStat2 = new System.Windows.Forms.TextBox();
            this.textBoxStat3 = new System.Windows.Forms.TextBox();
            this.textBoxStat4 = new System.Windows.Forms.TextBox();
            this.textBoxStat5 = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxReturn
            // 
            this.pictureBoxReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxReturn.Image")));
            this.pictureBoxReturn.Location = new System.Drawing.Point(16, 505);
            this.pictureBoxReturn.Name = "pictureBoxReturn";
            this.pictureBoxReturn.Size = new System.Drawing.Size(49, 41);
            this.pictureBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxReturn.TabIndex = 0;
            this.pictureBoxReturn.TabStop = false;
            this.pictureBoxReturn.Click += new System.EventHandler(this.pictureBoxReturn_Click);
            // 
            // pictureBoxQuit
            // 
            this.pictureBoxQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxQuit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxQuit.Image")));
            this.pictureBoxQuit.Location = new System.Drawing.Point(907, 505);
            this.pictureBoxQuit.Name = "pictureBoxQuit";
            this.pictureBoxQuit.Size = new System.Drawing.Size(43, 41);
            this.pictureBoxQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQuit.TabIndex = 1;
            this.pictureBoxQuit.TabStop = false;
            this.pictureBoxQuit.Click += new System.EventHandler(this.pictureBoxQuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Items :";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(213, 30);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Charger";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Informations :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Classe :";
            // 
            // textBoxClasse
            // 
            this.textBoxClasse.Location = new System.Drawing.Point(118, 160);
            this.textBoxClasse.Name = "textBoxClasse";
            this.textBoxClasse.Size = new System.Drawing.Size(100, 20);
            this.textBoxClasse.TabIndex = 8;
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Location = new System.Drawing.Point(118, 204);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(37, 20);
            this.textBoxLevel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Level :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Prix :";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(118, 247);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 12;
            // 
            // textBoxSellPrice
            // 
            this.textBoxSellPrice.Location = new System.Drawing.Point(118, 291);
            this.textBoxSellPrice.Name = "textBoxSellPrice";
            this.textBoxSellPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxSellPrice.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prix de vente :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Statistique 1 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Statistique 2 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Statistique 3 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Statistique 4 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Statistique 5 :";
            // 
            // textBoxStat1
            // 
            this.textBoxStat1.Location = new System.Drawing.Point(371, 204);
            this.textBoxStat1.Name = "textBoxStat1";
            this.textBoxStat1.Size = new System.Drawing.Size(100, 20);
            this.textBoxStat1.TabIndex = 20;
            // 
            // textBoxStat2
            // 
            this.textBoxStat2.Location = new System.Drawing.Point(371, 248);
            this.textBoxStat2.Name = "textBoxStat2";
            this.textBoxStat2.Size = new System.Drawing.Size(100, 20);
            this.textBoxStat2.TabIndex = 21;
            // 
            // textBoxStat3
            // 
            this.textBoxStat3.Location = new System.Drawing.Point(371, 291);
            this.textBoxStat3.Name = "textBoxStat3";
            this.textBoxStat3.Size = new System.Drawing.Size(100, 20);
            this.textBoxStat3.TabIndex = 22;
            // 
            // textBoxStat4
            // 
            this.textBoxStat4.Location = new System.Drawing.Point(371, 331);
            this.textBoxStat4.Name = "textBoxStat4";
            this.textBoxStat4.Size = new System.Drawing.Size(100, 20);
            this.textBoxStat4.TabIndex = 23;
            // 
            // textBoxStat5
            // 
            this.textBoxStat5.Location = new System.Drawing.Point(371, 374);
            this.textBoxStat5.Name = "textBoxStat5";
            this.textBoxStat5.Size = new System.Drawing.Size(100, 20);
            this.textBoxStat5.TabIndex = 24;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(708, 204);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(193, 190);
            this.richTextBoxDescription.TabIndex = 25;
            this.richTextBoxDescription.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(609, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Description :";
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUpdate.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUpdate.Image")));
            this.pictureBoxUpdate.Location = new System.Drawing.Point(545, 423);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(96, 94);
            this.pictureBoxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUpdate.TabIndex = 27;
            this.pictureBoxUpdate.TabStop = false;
            this.pictureBoxUpdate.Click += new System.EventHandler(this.pictureBoxUpdate_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(429, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(472, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // comboBoxName
            // 
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(75, 32);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxName.TabIndex = 31;
            // 
            // Appli3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 568);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxUpdate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxStat5);
            this.Controls.Add(this.textBoxStat4);
            this.Controls.Add(this.textBoxStat3);
            this.Controls.Add(this.textBoxStat2);
            this.Controls.Add(this.textBoxStat1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSellPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLevel);
            this.Controls.Add(this.textBoxClasse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxQuit);
            this.Controls.Add(this.pictureBoxReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Appli3";
            this.Text = "Items";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxReturn;
        private System.Windows.Forms.PictureBox pictureBoxQuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClasse;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxSellPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxStat1;
        private System.Windows.Forms.TextBox textBoxStat2;
        private System.Windows.Forms.TextBox textBoxStat3;
        private System.Windows.Forms.TextBox textBoxStat4;
        private System.Windows.Forms.TextBox textBoxStat5;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBoxName;
    }
}