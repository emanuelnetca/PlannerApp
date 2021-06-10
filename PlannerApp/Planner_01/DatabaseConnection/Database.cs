using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public class Database
    {

        #region Private Member Variables and Constants
        private static string _host = "server=localhost;port=3306;username=root;password=;database=plannerdb";
        // creare noua conexiune
        private MySqlConnection _connection;

        private static Database instance = new Database();
        private Database()
        {
            _connection = new MySqlConnection(_host);
        }
        #endregion

        #region Constructors
        public static Database Instance
        {
            get
            {
                if (instance == null)
                    instance = new Database();
                return instance;
            }
        }
        /// <summary>
        /// new function to open conection
        /// </summary>
        public void openConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    _connection.Open();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        /// <summary>
        /// new function to close the conection
        /// </summary>
        public void closeConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
        #endregion

        public MySqlConnection getConnection()
        {
            return _connection;
        }
    }
}
