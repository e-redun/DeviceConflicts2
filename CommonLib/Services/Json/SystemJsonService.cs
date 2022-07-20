using CommonLib.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace CommonLib.Services
{
    /// <summary>
    /// System.Text.Json-служба
    /// </summary>
    public class SystemJsonService : IJsonService
    {
        ILogger Logger { get; set; }


        /// <summary>
        /// System.Text.Json-служба
        /// </summary>
        /// <param name="logger">Логгер</param>
        public SystemJsonService(ILogger logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// Сериализует коллекцию конфликтов
        /// </summary>
        /// <param name="conflicts">Коллекция конфликтов</param>
        /// <returns>Строка в json-формате</returns>
        public string Serialize(IEnumerable<IConflict> conflicts)
        {
            string output = "";

            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                output = JsonSerializer.Serialize(conflicts, options);
            }
            catch
            {
                Logger.Add($"Не удалось сериализовать Conflicts");
            }

            return output;
        }

        /// <summary>
        /// Десериализует json-строку d коллекцию конфликтов
        /// </summary>
        /// <param name="jsonDataString">Строка в json-формате</param>
        /// <returns>Коллекция конфликтов</returns>
        public IEnumerable<IDeviceInfo> Deserialize(string jsonDataString)
        {
            IEnumerable<IDeviceInfo> output = null;

            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                output = JsonSerializer.Deserialize<IEnumerable<DeviceInfo>>(jsonDataString, options);
            }
            catch
            {
                Logger.Add($"Не удалось десериализовать Devices");
            }

            return output;
        }
    }
}