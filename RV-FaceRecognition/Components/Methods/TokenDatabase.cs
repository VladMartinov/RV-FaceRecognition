using System;
using System.Data.SqlClient;

namespace RV_FaceRecognition.Components.Methods
{
    public class TokenDatabase
    {
        #region -- Values --
        private string connectionString;

        private string token;
        private string login;
        private DateTime creationTime;

        public string Token
        {
            get => token;
        }
        public string Login
        {
            get => login;
        }
        public DateTime CreationTime
        {
            get => creationTime;
        }
        #endregion

        public TokenDatabase(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Method that checks the presence of a token in the database
        public bool TokenExists(string token)
        {
            bool exists = false;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT USER_LOGIN, DATE_CREATE FROM TOKENS WHERE TOKEN_ID = @TOKEN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TOKEN", token);

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return exists;
                exists = true;

                reader.Read();

                this.token = token;
                this.login = reader.GetString(0).ToString();
                this.creationTime = reader.GetDateTime(1);

                reader.Close();
            }

            return exists;
        }

        // Method that add a new token to the database
        public void SaveToken(string token, string userLogin)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO TOKENS (TOKEN_ID, USER_LOGIN) VALUES (@TOKEN, @USER_LOGIN)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TOKEN", token);
                command.Parameters.AddWithValue("@USER_LOGIN", userLogin);

                command.ExecuteNonQuery();
            }
        }

        // Method that removes a token from the database
        public void RemoveTokenFromDatabase(string token)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM TOKENS WHERE TOKEN_ID = @TOKEN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TOKEN", token);

                command.ExecuteNonQuery();
            }
        }
    }
}
