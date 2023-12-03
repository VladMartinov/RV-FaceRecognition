using System;
using System.Data.SqlClient;

namespace RV_FaceRecognition.Components.Methods
{
    public class TokenDatabase
    {
        #region -- Values --
        private string connectionString;

        private string token;
        private int usersId;
        private DateTime creationTime;

        public string Token
        {
            get => token;
        }
        public int UsersId
        {
            get => usersId;
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

                string query = "SELECT USERS_ID, DATE_CREATE FROM TOKENS WHERE TOKEN_ID = @TOKEN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TOKEN", token);

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return exists;
                exists = true;

                reader.Read();

                this.token = token;
                this.usersId = reader.GetInt32(0);
                this.creationTime = reader.GetDateTime(1);

                reader.Close();
            }

            return exists;
        }

        // Method that add a new token to the database
        public void SaveToken(string token, int usersId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO TOKENS (TOKEN_ID, USERS_ID) VALUES (@TOKEN, @USERS_ID)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TOKEN", token);
                command.Parameters.AddWithValue("@USERS_ID", usersId);

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
