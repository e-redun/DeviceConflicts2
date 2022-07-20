using CommonLib.Models;
using System.Collections.Generic;
using System.Linq;

namespace CommonLib.Services
{
    /// <summary>
    /// Служба LINQ-запросов
    /// </summary>
    public class QueryLinqService : ILinqService
    {
        /// <summary>
        /// Возвращает коллекцию конфликтов
        /// </summary>
        /// <param name="devices">Коллекция устройств</param>
        /// <returns>Коллекция конфликтов</returns>
        public IEnumerable<IConflict> GetDeviceGroups(IEnumerable<IDeviceInfo> devices)
        {
            var groups = from p in devices
                         orderby p.Brigade.Code
                         group p.Device by p.Brigade.Code into g
                         where g.Count() > 1
                         select new
                         {
                             BrigadeCode = g.Key,
                             Devices = from p in g select p
                         };

            var output = from p in groups
                         where p.Devices.Any(q => q.IsOnline == true)
                         select new Conflict
                         {
                             BrigadeCode = p.BrigadeCode,
                             DevicesSerials = p.Devices.Select(q => q.SerialNumber).ToArray()
                         };

            return output;
        }
    }
}
