using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppliDrago
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonMonster_Click(object sender, EventArgs e)
        {
            Appli1 appli1 = new Appli1();
            appli1.ShowDialog();
            
        }

        private bool AppliQuit()
        {
            if (MessageBox.Show("Quitter l'application ?", "Message de confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return false;
            };
            Application.Exit();
            return true;
        }


        private void pictureBoxQuit_Click(object sender, EventArgs e)
        {
            AppliQuit();
        }

        private void pictureBoxReturn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void buttonDrop_Click(object sender, EventArgs e)
        {
            Appli2 drop = new Appli2();
            drop.ShowDialog();
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            Appli3 items = new Appli3();
            items.ShowDialog();
        }

        private void buttonSkill_Click(object sender, EventArgs e)
        {
            Appli4 skill = new Appli4();
            skill.ShowDialog();
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            string file = DBConnect.getInstance().Backup();
            MessageBox.Show("Base de données sauvegardé dans le dossier suivant : C:\\Backup\\"+file+"");
        }

        

    }
}
