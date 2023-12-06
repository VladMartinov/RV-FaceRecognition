using System.Data.SqlClient;

namespace RV_FaceRecognition.Components.Methods
{
    public class UsersDatabase
    {
        #region -- Values --
        private int usersId;
        private string connectionString;
        #endregion

        public UsersDatabase(int usersId, string connectionString)
        {
            this.usersId = usersId;
            this.connectionString = connectionString;
        }

        public string GetUserLogin()
        {
            string result;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT USER_LOGIN FROM USERS WHERE USERS_ID = @USERS_ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@USERS_ID", this.usersId);

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) result = null;

                reader.Read();

                result = reader.GetString(0);

                reader.Close();
            }

            return result;
        }
    }
}
