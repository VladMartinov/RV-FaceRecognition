﻿using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RV_FaceRecognition.Components.Methods;

namespace RV_FaceRecognition
{
    public partial class FormRegister : Form
    {
        #region -- Values --
        private string loginValue;
        private string passwordValue;
        private string validationPattern = "[^a-zA-Z0-9!@#]";

        public string login
        {
            get => loginValue;
        }
        public string password
        {
            get => passwordValue;
        }
        #endregion

        public FormRegister()
        {
            InitializeComponent();

            customTextBoxPassword.UseSystemPasswordChar = true;
            pictureBoxPassword.BackgroundImage = Properties.Resources.hide;
        }

        // Выбор поля Обычного пользователя
        private void CustomCheckBoxDeffault_Click(object sender, MouseEventArgs e)
        {
            if (!customCheckBoxDeffault.IsChecked)
                customCheckBoxAdmin.IsChecked = false;
        }

        // Выбор поля Администратора
        private void CustomCheckBoxAdmin_Click(object sender, MouseEventArgs e)
        {
            if (!customCheckBoxAdmin.IsChecked)
                customCheckBoxDeffault.IsChecked = false;
        }

        // Проверяем введенные поля и в случае успеха регистрируем нового пользователя
        private void CustomButtonRegister_Click(object sender, EventArgs e)
        {
            if (customTextBoxLogin.Text.Length < 1 || customTextBoxPassword.Text.Length < 1) return;

            string loginToSend = customTextBoxLogin.Text;
            string passwordToSend = customTextBoxPassword.Text;

            Regex regex = new Regex(this.validationPattern, RegexOptions.IgnoreCase);

            if (regex.IsMatch(loginToSend))
            {
                MessageBox.Show("Введён некорректный логин!");
                return;
            }
            if (regex.IsMatch(passwordToSend))
            {
                MessageBox.Show("Введён некорректный пароль!");
                return;
            }

            passwordToSend = PasswordEncryption.HashedPassword(passwordToSend);

            int isAdmin = customCheckBoxAdmin.IsChecked ? 2 : 1;

            bool result;
            int usersId;

            using (var conn = new SqlConnection(Properties.Settings.Default.rv_facerecognitionConnectionString))
            using (var cmd = new SqlCommand("CREATE_USER", conn) { CommandType = CommandType.StoredProcedure })
            {
                cmd.Parameters.Add(new SqlParameter("@USER_LOGIN", loginToSend));
                cmd.Parameters.Add(new SqlParameter("@USER_PASSWORD", passwordToSend));
                cmd.Parameters.Add(new SqlParameter("@ROLE_ID", isAdmin));

                SqlParameter resultParameter = new SqlParameter("@RESULT", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                SqlParameter usersIdParameter = new SqlParameter("@USERS_ID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                
                cmd.Parameters.Add(resultParameter);
                cmd.Parameters.Add(usersIdParameter);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                result = (bool) resultParameter.Value;
                usersId = (int) usersIdParameter.Value;
            };

            if (result)
            {
                MessageBox.Show("Пользователь успешно создан!");

                this.loginValue = loginToSend;
                this.passwordValue = customTextBoxPassword.Text;

                RecordsManager recordsManager = new RecordsManager(usersId);
                recordsManager.RegisterAction(TypeActiom.CreateUser, $"Был добавлен новый пользователь: {this.loginValue}");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Произошла ошибка, пользователь не был добавлен.");
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }

        // Показ или сокрытие поля с вводом пароля
        private void pictureBoxPassword_Click(object sender, EventArgs e)
        {
            // Изменение значения 
            customTextBoxPassword.UseSystemPasswordChar = !customTextBoxPassword.UseSystemPasswordChar;

            // Изменение изображения в зависимости от значения условия
            if (customTextBoxPassword.UseSystemPasswordChar)
                pictureBoxPassword.BackgroundImage = Properties.Resources.hide;
            else
                pictureBoxPassword.BackgroundImage = Properties.Resources.view;
        }
    }
}
