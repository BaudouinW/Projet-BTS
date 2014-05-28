using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

namespace AppliDrago
{
    public partial class Appli3 : Form
    {

        #region variable de connection
        private static MySqlConnection connect = null;
        private string connectionString;
        private string queryCombo;
        #endregion

        public Appli3()
        {
            InitializeComponent();
            Connection();
            MonstersCombo();
            this.comboBoxName.SelectedIndex = 0;
        }

        private void Connection()
        {
            connectionString = Login.coValue;

            try
            {
                connect = new MySqlConnection(connectionString);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
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
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
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
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        void MonstersCombo()
        {
            if (OpenConnection() == true)
            {
                queryCombo = "Select * from items ";
                MySqlCommand cmd = new MySqlCommand(queryCombo, connect);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string MonsterName = dr.GetString("Itemname");
                    comboBoxName.Items.Add(MonsterName);
                }

                dr.Close();
                CloseConnection();
            }
        }

        private void pictureBoxReturn_Click(object sender, EventArgs e)
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

        private void pictureBoxQuit_Click(object sender, EventArgs e)
        {
            AppliQuit();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Hashtable result = DBConnect.getInstance().Select("Select * from items where Itemname ='" + comboBoxName.SelectedItem + "'");
            textBoxClasse.Text = result["Classlimit"].ToString();
            textBoxLevel.Text = result["level"].ToString();
            textBoxPrice.Text = result["price"].ToString();
            textBoxSellPrice.Text = result["Sellprice"].ToString();
            textBoxStat1.Text = result["stat1"].ToString();
            textBoxStat2.Text = result["stat2"].ToString();
            textBoxStat3.Text = result["stat3"].ToString();
            textBoxStat4.Text = result["stat4"].ToString();
            textBoxStat5.Text = result["stat5"].ToString();
            richTextBoxDescription.Text = result["Description"].ToString();

            MessageBox.Show("Objet chargé", "Message de confirmation");

        }

        private void pictureBoxUpdate_Click(object sender, EventArgs e)
        {
            DBConnect.getInstance().Update("Update items set Itemname ='" + comboBoxName.SelectedItem + "', Classlimit ='" + textBoxClasse.Text + "', level='" + textBoxLevel.Text + "', price ='" + textBoxPrice.Text.Replace("'", "\''") + "', Sellprice ='" + textBoxSellPrice.Text.Replace("'", "\''") + "', stat1 ='" + textBoxStat1.Text + "', stat2 ='" + textBoxStat2.Text + "', stat3 = '" + textBoxStat3.Text + "', stat4 ='" + textBoxStat4.Text + "', stat5 ='" + textBoxStat5.Text + "', Description ='" + richTextBoxDescription.Text.Replace("'", "\''") + "'");
            MessageBox.Show("Objet mis à jour", "Message de confirmation");
        }

      

    }
}
