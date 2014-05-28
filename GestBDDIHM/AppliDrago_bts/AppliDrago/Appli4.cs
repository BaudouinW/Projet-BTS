using System;
using System.Collections;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppliDrago
{
    public partial class Appli4 : Form
    {
        #region variable de connection
        private static MySqlConnection connect = null;
        private string connectionString;
        private string queryCombo;
        #endregion

        public Appli4()
        {
            InitializeComponent();
            Connexion();
            SkillCombo();
            this.comboBoxSkill.SelectedIndex = 0;  
        }

        private void Connexion()
        {
            connectionString = Login.coValue;

            try
            {
                connect = new MySqlConnection(connectionString);
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static bool OpenConnection()
        {
            try
            {
                connect.Open();
                return true;
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private static bool CloseConnection()
        {
            try
            {
                connect.Close();
                return true;
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        void SkillCombo()
        {
            if (OpenConnection() == true)
            {

                queryCombo = "select * from skills";
                MySqlCommand cmd = new MySqlCommand(queryCombo, connect);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string skillname = dr.GetString("Skillname");
                    comboBoxSkill.Items.Add(skillname);
                }

                dr.Close();
                CloseConnection();
            }
        }



        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            AppliQuit();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Hashtable result = DBConnect.getInstance().Select("Select * from skills where SKillname ='"+comboBoxSkill.SelectedItem+ "'");
            textBoxClasse.Text = result["Classe"].ToString();
            textBoxLevel.Text = result["Level"].ToString();
            textBoxCategorie.Text = result["Categorie"].ToString();
            textBoxElement.Text = result["Element"].ToString();
            textBoxPortee.Text = result["Portee"].ToString();
            textBoxCout.Text = result["Cout"].ToString();
            textBoxIncante.Text = result["TpsIncante"].ToString();
            textBoxTpsEffet.Text = result["TpsEffet"].ToString();
            textBoxIdEffet.Text = result["idEffet"].ToString();
            textBoxDegMin.Text = result["DegMin"].ToString();
            textBoxDegMax.Text = result["DegMax"].ToString();
            richTextBoxDescription.Text = result["Description"].ToString();
            System.Windows.Forms.MessageBox.Show("Objet chargé", "Message de confirmation");
        }

        private void pictureBoxUpdate_Click(object sender, EventArgs e)
        {

            DBConnect.getInstance().Update("Update skills set Skillname='" + comboBoxSkill.SelectedItem + "', Classe='" + textBoxClasse.Text + "', Level='" + textBoxLevel.Text + "', Categorie='" + textBoxCategorie.Text + "', Element='" + textBoxCategorie.Text + "', Portee='" + textBoxPortee.Text + "', Cout='" + textBoxCout.Text + "', TpsIncante='" + textBoxIncante.Text + "', TpsEffet='" + textBoxTpsEffet.Text + "', idEffet='" + textBoxIdEffet.Text + "', DegMin='" + textBoxDegMin.Text + "', DegMax='" + textBoxDegMax.Text + "', Description='" + richTextBoxDescription.Text.Replace("'", "\''") + "'");
            MessageBox.Show("Objet mis à jour", "Message de confirmation");
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
