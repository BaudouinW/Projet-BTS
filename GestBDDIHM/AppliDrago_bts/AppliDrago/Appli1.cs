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
    public partial class Appli1 : Form
    {
        #region variable de connection
        private static MySqlConnection connect = null;
        private string query;
        private string connectionString;
        private string queryCombo;
        #endregion

        public Appli1()
        {
            InitializeComponent();
            Connection();
            ComboMonster();
            this.comboBoxMonster.SelectedIndex = 0;
        }

        void ComboMonster()
        {
            if (OpenConnection() == true)
            {
                queryCombo = "Select * from monsters ";
                MySqlCommand cmd = new MySqlCommand(queryCombo, connect);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string MonsterName = dr.GetString("Monstrename");
                    comboBoxMonster.Items.Add(MonsterName);                
                }

                dr.Close();
                CloseConnection();
            }
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
            
            Hashtable result = DBConnect.getInstance().Select("Select * from monsters where Monstrename ='" + comboBoxMonster.SelectedItem + "'");
            textBoxLevel.Text = result["Level"].ToString();
            textBoxPV.Text = result["PV"].ToString();
            textBoxType.Text = result["Type"].ToString();
            textBoxElement.Text = result["Element"].ToString();
            richTextBox1.Text = result["Description"].ToString();
            textBoxMap.Text = result["Map"].ToString();
            textBoxPosX.Text = result["PositionX"].ToString();
            textBoxPosY.Text = result["PositionY"].ToString();
            textBoxPosZ.Text = result["PositionZ"].ToString();


            if (OpenConnection() == true)
            {
                listView1.Items.Clear();

                query = "Select skills.Skillname, skills.Description from skills, monsters, monsterandskill where Monstrename = '" +comboBoxMonster.SelectedItem+ "' AND skills.idSkill = monsterandskill.idSKill AND monsters.idMonstre = monsterandskill.idMonstre";
                MySqlCommand cmd = new MySqlCommand(query, connect);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem li = new ListViewItem(dr["Skillname"].ToString());
                    li.SubItems.Add(dr["Description"].ToString());
                    listView1.Items.Add(li);
                }
                dr.Close();
                CloseConnection();
            }

            
      
            MessageBox.Show("Objet chargé", "Message de confirmation");
        }

        private void pictureBoxUpdate_Click(object sender, EventArgs e)
        {
            DBConnect.getInstance().Update("Update monsters set Monstrename = '" + comboBoxMonster.SelectedItem + "', Level =" + textBoxLevel.Text + ", PV = " + textBoxPV.Text + ", Type = '" + textBoxType.Text + "', Element= '" + textBoxElement.Text + "', Description= '" + richTextBox1.Text.Replace("'", "\''") + "', Map ='" + textBoxMap.Text.Replace("'", "\''") + "', PositionX =" + textBoxPosX.Text + ", PositionY = " + textBoxPosY.Text + ", PositionZ =" + textBoxPosZ.Text + "");
           MessageBox.Show("Objet mis à jour", "Message de confirmation");            
        }

        
      
    }
}
