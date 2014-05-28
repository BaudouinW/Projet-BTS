using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Windows.Forms;

namespace AppliDrago
{
    class DBConnect
    {
        #region variable de classe
        private static MySqlConnection connection = null;
        private static DBConnect instance = null;
        #endregion
        
       public static DBConnect getInstance()
        {
            if (instance == null)
            {
                instance = new DBConnect();
            }
            return instance;
        }

        private DBConnect()
        {
            Initialize();
        }
        ~DBConnect()
        {
            try
            {
                connection.Close();
            }
            finally
            {
            }
        }

        private void Initialize()
        {
            string connectionString;
            connectionString = Login.coValue;

            try
            {
                connection = new MySqlConnection(connectionString);
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
                connection.Open();
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
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Update(string query)
        {


            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public Hashtable Select(string query)
        {

            Hashtable columns = new Hashtable();


            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        columns.Add(dataReader.GetName(i), dataReader.GetString(i));
                    }
                    
                }
                dataReader.Close();
                CloseConnection();
                return columns;
            }
            else
            {
                return columns;
            }
        }

        public void Insert(string query)
        {
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

                
}
        
    

