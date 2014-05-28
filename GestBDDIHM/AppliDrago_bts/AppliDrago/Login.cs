using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Microsoft.Win32;



namespace AppliDrago
{
    public partial class Login : Form
    {
        #region variable de classe
        private static MySqlConnection connection = null;
        private static ConnexionItem connectioniTem;
        #endregion

        public Login()
        {
            InitializeComponent();
           
        }

        private void buttonNvlCo_Click(object sender, EventArgs e)
        {
            NvlCo nvlco = new NvlCo(this);
            nvlco.ShowDialog();
            
        }

        private void comboCo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            connectioniTem = (ConnexionItem)comboCo.SelectedItem;
           
        }

        public static string coValue
        {
            get { return connectioniTem.Value; }
        }



        private void Login_Load(object sender, EventArgs e)
        {
           
            string[] keys =  Registry.CurrentUser.OpenSubKey("Connexion BDD").GetValueNames();

            foreach (string key in keys)
                comboCo.Items.Add(new ConnexionItem(key, (String)Registry.CurrentUser.OpenSubKey("Connexion BDD").GetValue(key)));

            this.comboCo.SelectedIndex = 0;
        }

        private static bool OpenConnection()
        {
          try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        private static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {    
                return false;
            }
        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {

            try
            {
                connection = new MySqlConnection(connectioniTem.Value);

            }
            catch { }

            if (OpenConnection() == true)
            {
                MessageBox.Show("Connexion réussi", "Message de confirmation");
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erreur de login");
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

        
     
    }
}
