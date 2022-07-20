using System.IO;

namespace CommonLib.Services
{
    /// <summary>
    /// Коннектор с файловой системой
    /// </summary>
    public class FileConnector : IDataConnector
    {
        private string devicesFileName = GlobalConfig.GetAppSettings("devicesFileName");

        private string conflictsFileName = GlobalConfig.GetAppSettings("conflictsFileName");


        // Логгер
        private ILogger _logger;


        /// <summary>
        /// Коннектор с файловой системой
        /// </summary>
        public FileConnector(ILogger logger)
        {
            _logger = logger;
        }


        /// <summary>
        /// Читает данные из файла
        /// </summary>
        /// <returns>Содержимое файла</returns>
        public string ReadData()
        {
            string output = "";

            try
            {
                string devicesFilePath = FileService.GetFullPath(devicesFileName);

                output = File.ReadAllText(devicesFilePath);
            }
            catch
            {
                _logger.Add($"Не удалось считать файл {devicesFileName}");
            }

            return output;
        }


        /// <summary>
        /// Сохраняет данные в файл
        /// </summary>
        /// <param name="data">Записываемые данные</param>
        public void SaveData(string data)
        {
            try
            {
                string conflictsFilePath = FileService.GetFullPath(conflictsFileName);

                File.WriteAllText(conflictsFilePath, data);
            }
            catch
            {
                _logger.Add($"Не удалось сохранить файл {conflictsFileName}");
            }
        }
    }
}