using System.Collections.Generic;
using CommonLib.Models;

namespace CommonLib.Services
{
    /// <summary>
    /// LINQ-служба
    /// </summary>
    public interface ILinqService
    {
        /// <summary>
        /// Возвращает коллекцию конфликтов
        /// </summary>
        /// <param name="devices">Коллекция устройств</param>
        /// <returns>Коллекция конфликтов</returns>
        IEnumerable<IConflict> GetDeviceGroups(IEnumerable<IDeviceInfo> devices);
    }
}