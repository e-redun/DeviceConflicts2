using System.Collections.Generic;
using CommonLib.Models;

namespace CommonLib.Services
{
    /// <summary>
    /// Интерфейс Json-службы 
    /// </summary>
    public interface IJsonService
    {
        /// <summary>
        /// Сериализует коллекцию конфликтов
        /// </summary>
        /// <param name="conflicts">Коллекция конфликтов</param>
        /// <returns>Строка в json-формате</returns>
        string Serialize(IEnumerable<IConflict> conflicts);
        
        /// <summary>
        /// Десериализует json-строку d коллекцию конфликтов
        /// </summary>
        /// <param name="jsonDataString">Строка в json-формате</param>
        /// <returns>Коллекция конфликтов</returns>
        IEnumerable<IDeviceInfo> Deserialize(string jsonDataString);
    }
}