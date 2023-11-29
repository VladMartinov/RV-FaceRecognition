using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RV_FaceRecognition.Components.Methods;

namespace RV_FaceRecognition
{
    public partial class FormLogin : Form
    {
        #region -- Values --
        private string loginValue;
        private string passwordValue;
        private string roleValue;
        private int roleIdValue;
        private readonly string validationPattern = "[^a-zA-Z0-9!@#]";

        public string login
        {
            get => loginValue;
        }
        public string password
        {
            get => passwordValue;
        }
        public string role
        {
            get => roleValue;
        }
        public int roleId
        {
            get => roleIdValue;
        }
        #endregion

        public FormLogin()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.ShowDialog();

            if (formRegister.DialogResult == DialogResult.OK)
            {
                customTextBoxLogin.Text = formRegister.login;
                customTextBoxPassword.Text = formRegister.password;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(this.validationPattern, RegexOptions.IgnoreCase);

            FormInputMessage formInputMessage = new FormInputMessage("Введите логин:");
            formInputMessage.ShowDialog();

            if (formInputMessage.DialogResult != DialogResult.OK) return;
            if (regex.IsMatch(formInputMessage.input))
            {
                MessageBox.Show("Введён некорректный логин!");
                return;
            }
            string recoveryLogin = formInputMessage.input;

            formInputMessage = new FormInputMessage("Введите пароль:");
            formInputMessage.ShowDialog();

            if (formInputMessage.DialogResult != DialogResult.OK) return;
            if (regex.IsMatch(formInputMessage.input))
            {
                MessageBox.Show("Введён некорректный пароль!");
                return;
            }
            string recoveryPassword = PasswordEncryption.HashedPassword(formInputMessage.input);

            bool result;

            using (var conn = new SqlConnection(Properties.Settings.Default.rv_facerecognitionConnectionString))
            using (var cmd = new SqlCommand("UPDATE_USER_PASSWORD", conn) { CommandType = CommandType.StoredProcedure })
            {
                cmd.Parameters.Add(new SqlParameter("@USER_LOGIN", recoveryLogin));
                cmd.Parameters.Add(new SqlParameter("@USER_PASSWORD", recoveryPassword));
                SqlParameter sqlParameter = new SqlParameter("@RESULT", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(sqlParameter);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                result = (bool)sqlParameter.Value;
            };

            string resultMessage = result ? "Пароль успешно изменён!" : "Произошла ошибка, не удалось изменить пароль";
            MessageBox.Show(resultMessage);
        }

        private void customButtonLogIn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(this.validationPattern, RegexOptions.IgnoreCase);

            if (customTextBoxLogin.Text.Length < 1 || regex.IsMatch(customTextBoxLogin.Text))
            {
                MessageBox.Show("Введён некорректный логин!");
                return;
            }
            string currentLogin =  customTextBoxLogin.Text;

            if (customTextBoxPassword.Text.Length < 1 || regex.IsMatch(customTextBoxPassword.Text))
            {
                MessageBox.Show("Введён некорректный пароль!");
                return;
            }
            string currentPassword = PasswordEncryption.HashedPassword(customTextBoxPassword.Text);

            bool result;

            using (var conn = new SqlConnection(Properties.Settings.Default.rv_facerecognitionConnectionString))
            using (var cmd = new SqlCommand("USER_AUTHORIZATION", conn) { CommandType = CommandType.StoredProcedure })
            {
                cmd.Parameters.Add(new SqlParameter("@USER_LOGIN", currentLogin));
                cmd.Parameters.Add(new SqlParameter("@USER_PASSWORD", currentPassword));
                SqlParameter sqlParameter = new SqlParameter("@RESULT_FLAG", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(sqlParameter);
                SqlParameter sqlParameterSecond = new SqlParameter("@RESULT_ROLE", SqlDbType.SmallInt)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(sqlParameterSecond);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                result = (bool)sqlParameter.Value;

                if (result)
                {
                    this.loginValue = currentLogin;
                    this.passwordValue = customTextBoxPassword.Text;
                    this.roleIdValue = Convert.ToInt16(sqlParameterSecond.Value);
                }
            };

            if (result)
            {
                using (var conn = new SqlConnection(Properties.Settings.Default.rv_facerecognitionConnectionString))
                using (var cmd = new SqlCommand("SELECT ROLE_NAME FROM ROLES WHERE ROLE_ID = @ID;", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@ID", this.roleIdValue));

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows) return;

                    reader.Read();
                    this.roleValue = reader.GetString(0);

                    reader.Close();
                    conn.Close();
                }
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Авторизация неудачна, попробуйте еще раз");
        }
    }
}
