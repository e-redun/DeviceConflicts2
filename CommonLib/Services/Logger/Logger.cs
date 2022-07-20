using System.Text;

namespace CommonLib.Services
{
    /// <summary>
    /// Логгер
    /// </summary>
    public class Logger : ILogger
    {
        private StringBuilder log = new StringBuilder();

        /// <summary>
        /// Добавляет запись в лог
        /// </summary>
        /// <param name="record">Запись</param>
        public void Add(string record)
        {
            log.AppendLine(record);
        }

        /// <summary>
        /// Возвращает содержимое лога
        /// </summary>
        /// <returns>Содержимое лога</returns>
        public string GetLog()
        {
            return log.ToString();
        }
    }
}