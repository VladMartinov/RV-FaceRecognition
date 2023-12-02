using System.Data;
using System.Data.SqlClient;

namespace RV_FaceRecognition.Components.Methods
{
    public enum TypeActiom
    {
        CreateUser = 1,
        UpdateUser = 2,
        Authorize = 3,
        AddImage = 4,
        UpdateImage = 5,
        DeleteImage = 6
    }

    public class RecordsManager
    {
        #region -- Values --
        private string login;
        #endregion

        public RecordsManager(string login)
        {
            this.login = login;
        }

        // Method that adds an instance of an entity to the Database Records table
        public void RegisterAction (TypeActiom typeAction, string description = "")
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.rv_facerecognitionConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO RECORDS (USER_LOGIN, ACTION_ID, RECORD_DESCRIPTION) VALUES (@USER_LOGIN, @ACTION_ID, @RECORD_DESCRIPTION)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@USER_LOGIN", SqlDbType.VarChar, 20) { Value = this.login });
                command.Parameters.Add(new SqlParameter("@ACTION_ID", SqlDbType.SmallInt) { Value = (int) typeAction });

                if (description.Length > 0)
                    command.Parameters.Add(new SqlParameter("@RECORD_DESCRIPTION", SqlDbType.VarChar, 75) { Value = description });

                command.ExecuteNonQuery();
            }
        }
    }
}
