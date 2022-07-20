namespace CommonLib.Services
{
    /// <summary>
    /// Интерфейс логгера
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Добавляет запись в лог
        /// </summary>
        /// <param name="record">Запись</param>
        void Add(string record);

        /// <summary>
        /// Возвращает содержимое лога
        /// </summary>
        /// <returns>Содержимое лога</returns>
        string GetLog();
    }
}