namespace CommonLib.Services
{
    /// <summary>
    /// Интерфейс доступа к данным
    /// </summary>
    public interface IDataConnector
    {
        /// <summary>
        /// Читает данные из файла
        /// </summary>
        /// <returns>Содержимое файла</returns>
        string ReadData();

        /// <summary>
        /// Сохраняет данные в файл
        /// </summary>
        /// <param name="data">Записываемые данные</param>
        void SaveData(string jsonData);
    }
}