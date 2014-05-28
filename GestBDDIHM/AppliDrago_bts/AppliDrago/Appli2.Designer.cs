namespace AppliDrago
{
    partial class Appli2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appli2));
            this.pictureBoxReturn = new System.Windows.Forms.PictureBox();
            this.pictureBoxQuit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewDrop = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TauxDrop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTauxDrop = new System.Windows.Forms.TextBox();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.comboBoxMonsters = new System.Windows.Forms.ComboBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.comboBoxMonstre = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTaux = new System.Windows.Forms.TextBox();
            this.pictureUpdateDrop = new System.Windows.Forms.PictureBox();
            this.labelIdItem = new System.Windows.Forms.Label();
            this.labelMonstreID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUpdateDrop)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom du monstre :";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(258, 38);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Charger";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Informations :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Objets :";
            // 
            // listViewDrop
            // 
            this.listViewDrop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.TauxDrop});
            this.listViewDrop.LabelEdit = true;
            this.listViewDrop.Location = new System.Drawing.Point(84, 161);
            this.listViewDrop.Name = "listViewDrop";
            this.listViewDrop.Size = new System.Drawing.Size(193, 170);
            this.listViewDrop.TabIndex = 8;
            this.listViewDrop.UseCompatibleStateImageBehavior = false;
            this.listViewDrop.View = System.Windows.Forms.View.Details;
            this.listViewDrop.SelectedIndexChanged += new System.EventHandler(this.listViewDrop_SelectedIndexChanged);
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 102;
            // 
            // TauxDrop
            // 
            this.TauxDrop.Text = "Taux de drop";
            this.TauxDrop.Width = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nom de l\'objet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Taux :";
            // 
            // textBoxTauxDrop
            // 
            this.textBoxTauxDrop.Location = new System.Drawing.Point(266, 360);
            this.textBoxTauxDrop.Name = "textBoxTauxDrop";
            this.textBoxTauxDrop.Size = new System.Drawing.Size(49, 20);
            this.textBoxTauxDrop.TabIndex = 12;
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUpdate.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUpdate.Image")));
            this.pictureBoxUpdate.Location = new System.Drawing.Point(181, 415);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(96, 94);
            this.pictureBoxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUpdate.TabIndex = 13;
            this.pictureBoxUpdate.TabStop = false;
            this.pictureBoxUpdate.Click += new System.EventHandler(this.pictureBoxUpdate_Click);
            // 
            // comboBoxMonsters
            // 
            this.comboBoxMonsters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonsters.FormattingEnabled = true;
            this.comboBoxMonsters.Location = new System.Drawing.Point(109, 38);
            this.comboBoxMonsters.Name = "comboBoxMonsters";
            this.comboBoxMonsters.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMonsters.TabIndex = 14;
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(108, 363);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(35, 13);
            this.labelItemName.TabIndex = 15;
            this.labelItemName.Text = "label6";
            this.labelItemName.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ajout de drop :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nom de l\'objet :";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(569, 40);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(121, 21);
            this.comboBoxItems.TabIndex = 18;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxItems_SelectedIndexChanged);
            // 
            // comboBoxMonstre
            // 
            this.comboBoxMonstre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonstre.FormattingEnabled = true;
            this.comboBoxMonstre.Location = new System.Drawing.Point(629, 214);
            this.comboBoxMonstre.Name = "comboBoxMonstre";
            this.comboBoxMonstre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMonstre.TabIndex = 20;
            this.comboBoxMonstre.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonstre_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nom du monstre :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(533, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Taux de drop :";
            // 
            // textBoxTaux
            // 
            this.textBoxTaux.Location = new System.Drawing.Point(629, 158);
            this.textBoxTaux.Name = "textBoxTaux";
            this.textBoxTaux.Size = new System.Drawing.Size(44, 20);
            this.textBoxTaux.TabIndex = 23;
            // 
            // pictureUpdateDrop
            // 
            this.pictureUpdateDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureUpdateDrop.Image = ((System.Drawing.Image)(resources.GetObject("pictureUpdateDrop.Image")));
            this.pictureUpdateDrop.Location = new System.Drawing.Point(611, 415);
            this.pictureUpdateDrop.Name = "pictureUpdateDrop";
            this.pictureUpdateDrop.Size = new System.Drawing.Size(96, 94);
            this.pictureUpdateDrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUpdateDrop.TabIndex = 24;
            this.pictureUpdateDrop.TabStop = false;
            this.pictureUpdateDrop.Click += new System.EventHandler(this.pictureUpdateDrop_Click);
            // 
            // labelIdItem
            // 
            this.labelIdItem.AutoSize = true;
            this.labelIdItem.Location = new System.Drawing.Point(566, 76);
            this.labelIdItem.Name = "labelIdItem";
            this.labelIdItem.Size = new System.Drawing.Size(41, 13);
            this.labelIdItem.TabIndex = 25;
            this.labelIdItem.Text = "label10";
            this.labelIdItem.Visible = false;
            // 
            // labelMonstreID
            // 
            this.labelMonstreID.AutoSize = true;
            this.labelMonstreID.Location = new System.Drawing.Point(626, 253);
            this.labelMonstreID.Name = "labelMonstreID";
            this.labelMonstreID.Size = new System.Drawing.Size(41, 13);
            this.labelMonstreID.TabIndex = 26;
            this.labelMonstreID.Text = "label11";
            this.labelMonstreID.Visible = false;
            // 
            // Appli2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 568);
            this.Controls.Add(this.labelMonstreID);
            this.Controls.Add(this.labelIdItem);
            this.Controls.Add(this.pictureUpdateDrop);
            this.Controls.Add(this.textBoxTaux);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxMonstre);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelItemName);
            this.Controls.Add(this.comboBoxMonsters);
            this.Controls.Add(this.pictureBoxUpdate);
            this.Controls.Add(this.textBoxTauxDrop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewDrop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxQuit);
            this.Controls.Add(this.pictureBoxReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Appli2";
            this.Text = "Drop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUpdateDrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxReturn;
        private System.Windows.Forms.PictureBox pictureBoxQuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewDrop;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader TauxDrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTauxDrop;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private System.Windows.Forms.ComboBox comboBoxMonsters;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.ComboBox comboBoxMonstre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTaux;
        private System.Windows.Forms.PictureBox pictureUpdateDrop;
        private System.Windows.Forms.Label labelIdItem;
        private System.Windows.Forms.Label labelMonstreID;
    }
}