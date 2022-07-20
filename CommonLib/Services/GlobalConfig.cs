using System.Configuration;

namespace CommonLib.Services
{
    public class GlobalConfig
    {
        /// <summary>
        /// Возвращает настройки хранимые в файле App.config по ключу
        /// </summary>
        /// <param name="key">Ключ настройки</param>
        /// <returns>Настройка</returns>
        public static string GetAppSettings(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        /// Возвращает строку подключения из фала App.config
        /// </summary>
        /// <param name="name">Имя строки подключения</param>
        /// <returns>Строка подключения</returns>
        public static string GetConString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}