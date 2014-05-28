using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;

namespace AppliDrago
{
    public partial class Appli2 : Form
    {
        #region variable de connection
        private static MySqlConnection connect = null;
        private string query;
        private string connectionString;
        private string queryCombo;
        #endregion

        public Appli2()
        {
            InitializeComponent();
            Connection();
            MonstersCombo();
            ItemsCombo();
            this.comboBoxItems.SelectedIndex = 0;
            this.comboBoxMonsters.SelectedIndex = 0;
            this.comboBoxMonstre.SelectedIndex = 0;
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

        private bool AppliQuit()
        {
            if (MessageBox.Show("Quitter l'application ?", "Message de confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return false;
            };
            Application.Exit();
            return true;
        }

        private void pictureBoxReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxQuit_Click(object sender, EventArgs e)
        {
            AppliQuit();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (OpenConnection() == true)
            {
                listViewDrop.Items.Clear();

                query = "Select Itemname, md.TauxDrop from monsters m, items i, monsteranddrop md where Monstrename = '" + comboBoxMonsters.SelectedItem + "' AND i.iditem = md.idItem AND m.idMonstre = md.idMonstre";
                MySqlCommand cmd = new MySqlCommand(query, connect);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    
                    ListViewItem li = new ListViewItem(dr["Itemname"].ToString());
                    li.SubItems.Add(dr["TauxDrop"].ToString());
                    listViewDrop.Items.Add(li);
                }
                dr.Close();
                CloseConnection();
            }

            MessageBox.Show("Objet chargé", "Message de confirmation");
        }


        private void listViewDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDrop.SelectedItems.Count > 0)
            {
                labelItemName.Visible = true;
                labelItemName.Text = listViewDrop.SelectedItems[0].Text;
                textBoxTauxDrop.Text = listViewDrop.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void textBoxDropName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxUpdate_Click(object sender, EventArgs e)
        {
            DBConnect.getInstance().Update("Update monsteranddrop set TauxDrop ='" + textBoxTauxDrop.Text + "'");
            MessageBox.Show("Objet mis à jour");
        }

        void MonstersCombo()
        {
            if (OpenConnection() == true)
            {
                queryCombo = "Select * from monsters ";
                MySqlCommand cmd = new MySqlCommand(queryCombo, connect);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string MonsterName = dr.GetString("Monstrename");
                    comboBoxMonsters.Items.Add(MonsterName);
                    comboBoxMonstre.Items.Add(MonsterName);
                }

                dr.Close();
                CloseConnection();
            }
        }

        void ItemsCombo()
        {
            if (OpenConnection() == true)
            {
                queryCombo = "Select * from Items";
                MySqlCommand cmd = new MySqlCommand(queryCombo, connect);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string ItemName = dr.GetString("Itemname");
                    comboBoxItems.Items.Add(ItemName);
                }

                dr.Close();
                CloseConnection();
            }
        }

       
        private void pictureUpdateDrop_Click(object sender, EventArgs e)
        {
            DBConnect.getInstance().Insert("Insert into monsteranddrop values ("+labelIdItem.Text+", "+labelMonstreID.Text+", '"+textBoxTaux.Text+"')");
            MessageBox.Show("Objet mis à jour", "Message de confirmation");
        }

        private void comboBoxMonstre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hashtable result = DBConnect.getInstance().Select("Select idMonstre from monsters where Monstrename ='" + comboBoxMonstre.SelectedItem + "'");
            labelMonstreID.Text = result["idMonstre"].ToString();

        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hashtable result = DBConnect.getInstance().Select("Select iditem from items where Itemname = '" + comboBoxItems.SelectedItem + "'");
            labelIdItem.Text = result["iditem"].ToString();
        }

              
    }
}
