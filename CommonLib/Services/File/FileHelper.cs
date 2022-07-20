using System.IO;

namespace CommonLib.Services
{
    /// <summary>
    /// Служба работы с файлами
    /// </summary>
    public class FileService
    {
        /// <summary>
        /// Возвращает полный путь файла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <returns>Полный путь файла</returns>
        public static string GetFullPath(string fileName)
        {
            string folder = GlobalConfig.GetAppSettings("jsonFolder");

            return Path.Combine(folder, fileName);
        }
    }
}