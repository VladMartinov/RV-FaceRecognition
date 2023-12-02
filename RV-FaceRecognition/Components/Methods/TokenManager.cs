using System;
using Microsoft.Win32;


namespace RV_FaceRecognition.Components.Methods
{
    public class TokenManager
    {
        private TokenDatabase tokenDatabase;
        public string Login
        {
            get => tokenDatabase.Login;
        }

        public TokenManager(string connectionString)
        {
            tokenDatabase = new TokenDatabase(connectionString);
        }

        // Check, token is valid or not
        public bool IsTokenValid(string token)
        {
            // Проверяем наличие токена в базе данных
            if (tokenDatabase.TokenExists(token))
            {
                // Проверяем истечение токена
                if (TokenNotExpired(token))
                {
                    return true;
                }
            }

            return false;
        }

        public void SaveTokenToRegistry(string token, string login)
        {
            // Сохраняем токен в реестре ПК
            RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\RV-FaceRecognition");
            registryKey.SetValue("Token", token);

            tokenDatabase.SaveToken(token, login);
        }

        public string GetTokenFromRegistry()
        {
            // Получаем токен из реестра ПК
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\RV-FaceRecognition");
            if (registryKey == null) return null;
            
            string token = (string)registryKey.GetValue("Token");

            return token;
        }

        public void RemoveTokenFromRegistry()
        {
            // Удаляем значение токена из реестра ПК
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\RV-FaceRecognition", true);
            if (registryKey != null)
            {
                registryKey.DeleteValue("Token", false);
                registryKey.Close();
            }
        }

        private bool TokenNotExpired(string token)
        {
            bool valid = this.tokenDatabase.CreationTime.AddDays(1) > DateTime.Now;

            if (!valid)
            {
                // Удаляем токен из регистра и базы данных если он просрочен
                RemoveTokenFromRegistry();
                this.tokenDatabase.RemoveTokenFromDatabase(token);
            }

            return valid;
        }
    }
}
