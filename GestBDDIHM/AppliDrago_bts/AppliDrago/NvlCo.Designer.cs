namespace AppliDrago
{
    partial class NvlCo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NvlCo));
            this.idBox = new System.Windows.Forms.TextBox();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.nameCoBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureAdd = new System.Windows.Forms.PictureBox();
            this.pictureBoxReturn = new System.Windows.Forms.PictureBox();
            this.pictureBoxQuit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuit)).BeginInit();
            this.SuspendLayout();
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(207, 87);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(143, 20);
            this.idBox.TabIndex = 1;
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // pwdBox
            // 
            this.pwdBox.Location = new System.Drawing.Point(207, 133);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.PasswordChar = '*';
            this.pwdBox.Size = new System.Drawing.Size(143, 20);
            this.pwdBox.TabIndex = 2;
            this.pwdBox.UseSystemPasswordChar = true;
            this.pwdBox.TextChanged += new System.EventHandler(this.pwdBox_TextChanged);
            // 
            // nameCoBox
            // 
            this.nameCoBox.Location = new System.Drawing.Point(207, 241);
            this.nameCoBox.Name = "nameCoBox";
            this.nameCoBox.Size = new System.Drawing.Size(100, 20);
            this.nameCoBox.TabIndex = 3;
            this.nameCoBox.TextChanged += new System.EventHandler(this.nameCoBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User id :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password :";
            // 
            // saveCheckBox
            // 
            this.saveCheckBox.AutoSize = true;
            this.saveCheckBox.Location = new System.Drawing.Point(207, 188);
            this.saveCheckBox.Name = "saveCheckBox";
            this.saveCheckBox.Size = new System.Drawing.Size(164, 17);
            this.saveCheckBox.TabIndex = 7;
            this.saveCheckBox.Text = "sauvegarder cette connexion";
            this.saveCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Configuration d\'une nouvelle connexion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Donner un nom à cette connexion";
            // 
            // pictureAdd
            // 
            this.pictureAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureAdd.Image = ((System.Drawing.Image)(resources.GetObject("pictureAdd.Image")));
            this.pictureAdd.Location = new System.Drawing.Point(207, 294);
            this.pictureAdd.Name = "pictureAdd";
            this.pictureAdd.Size = new System.Drawing.Size(77, 70);
            this.pictureAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAdd.TabIndex = 12;
            this.pictureAdd.TabStop = false;
            this.pictureAdd.Tag = "Ajouter";
            this.pictureAdd.Click += new System.EventHandler(this.pictureAdd_Click);
            // 
            // pictureBoxReturn
            // 
            this.pictureBoxReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxReturn.Image")));
            this.pictureBoxReturn.Location = new System.Drawing.Point(28, 365);
            this.pictureBoxReturn.Name = "pictureBoxReturn";
            this.pictureBoxReturn.Size = new System.Drawing.Size(49, 41);
            this.pictureBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxReturn.TabIndex = 14;
            this.pictureBoxReturn.TabStop = false;
            this.pictureBoxReturn.Click += new System.EventHandler(this.pictureBoxReturn_Click);
            // 
            // pictureBoxQuit
            // 
            this.pictureBoxQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxQuit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxQuit.Image")));
            this.pictureBoxQuit.Location = new System.Drawing.Point(459, 365);
            this.pictureBoxQuit.Name = "pictureBoxQuit";
            this.pictureBoxQuit.Size = new System.Drawing.Size(43, 41);
            this.pictureBoxQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQuit.TabIndex = 15;
            this.pictureBoxQuit.TabStop = false;
            this.pictureBoxQuit.Click += new System.EventHandler(this.pictureBoxQuit_Click);
            // 
            // NvlCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 422);
            this.Controls.Add(this.pictureBoxQuit);
            this.Controls.Add(this.pictureBoxReturn);
            this.Controls.Add(this.pictureAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameCoBox);
            this.Controls.Add(this.pwdBox);
            this.Controls.Add(this.idBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NvlCo";
            this.Text = "Nouvelle Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox pwdBox;
        private System.Windows.Forms.TextBox nameCoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox saveCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureAdd;
        private System.Windows.Forms.PictureBox pictureBoxReturn;
        private System.Windows.Forms.PictureBox pictureBoxQuit;
    }
}