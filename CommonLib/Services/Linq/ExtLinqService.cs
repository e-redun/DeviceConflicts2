using CommonLib.Models;
using System.Collections.Generic;
using System.Linq;

namespace CommonLib.Services
{
    /// <summary>
    /// Служба методов раширения LINQ
    /// </summary>
    public class ExtLinqService : ILinqService
    {
        /// <summary>
        /// Возвращает коллекцию конфликтов
        /// </summary>
        /// <param name="devices">Коллекция устройств</param>
        /// <returns>Коллекция конфликтов</returns>
        public IEnumerable<IConflict> GetDeviceGroups(IEnumerable<IDeviceInfo> devices)
        {
            var groups = devices
                                .OrderBy(p => p.Brigade.Code)
                                .GroupBy(p => p.Brigade.Code)
                                .Where(p => p.Count() > 1)
                                .Select(g => new
                                {
                                    BrigadeCode = g.Key,
                                    Devices = g.Select(p => p.Device)
                                });

            var output = groups.Where(p => p.Devices.Any(q => q.IsOnline == true))
                               .Select(g => new Conflict
                               {
                                   BrigadeCode = g.BrigadeCode,
                                   DevicesSerials = g.Devices.Select(p => p.SerialNumber).ToArray()
                               });

            return output;
        }
    }
}