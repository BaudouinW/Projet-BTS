using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AppliDrago
{
    public partial class NvlCo : Form
    {
        #region variable de classe
        private static string serverText;
        private static string idText;
        private static string pwdText;
        private static string nameText;
        private static string coString;
        private Login parentF;
        RegistryKey coKey;
        #endregion

        public NvlCo(Login login)
        {
            parentF = login;
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void idBox_TextChanged(object sender, EventArgs e)
        {
            idText = idBox.Text;
        }

        public static string id
        {
            get { return idText; }
        }

        private void pwdBox_TextChanged(object sender, EventArgs e)
        {
            pwdText = pwdBox.Text;
        }

        public static string pwd
        {
            get { return pwdText; }
        }


        public static string CoString
        {
            get { return coString; }
        }

        private void nameCoBox_TextChanged(object sender, EventArgs e)
        {
            nameText = nameCoBox.Text;
        }

        public static string naText
        {
            get { return nameText; }
        }

        private void pictureAdd_Click(object sender, EventArgs e)
        {
            coString = "SERVER= localhost;DATABASE= dragonica ;UID=" + id + ";PASSWORD=" + pwd + ";";

            if (saveCheckBox.Checked)
            {

                ConnexionItem itm = new ConnexionItem(nameText, coString);
                parentF.comboCo.Items.Add(itm);
                coKey = Registry.CurrentUser.CreateSubKey("Connexion BDD");
                coKey.SetValue(nameText, coString);
                coKey.Close();
                parentF.comboCo.Refresh();
                this.Close();

            }
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
            this.Close();
        }

        
    
    }
}
