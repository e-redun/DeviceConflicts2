using CommonLib.Enums;

namespace CommonLib.Services
{
    /// <summary>
    /// Служба обработки конфликтов
    /// </summary>
    public class ConflictService : IConflictService
    {
        // Логгер
        private ILogger _logger;

        /// <summary>
        /// Служба обработки конфликтов
        /// </summary>
        public ConflictService(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Выполняет обработку конфликтов
        /// </summary>
        /// <returns>Отчет об ошибках</returns>
        public void Process()
        {
            IDataConnector dataConnector = ConnectorFactory.CreateConnector(ConnectionTypes.File, _logger);

            IJsonService jsonService = new SystemJsonService(_logger);

            ILinqService linqService = new QueryLinqService();


            // считывание содержимого json-файла данных приборов
            string jsonData = dataConnector.ReadData();

            if (HasError()) return;


            // десериализация
            var deviceInfos = jsonService.Deserialize(jsonData);

            if (HasError()) return;


            // получение конфликтов
            var conflicts = linqService.GetDeviceGroups(deviceInfos);


            // получение данных конфликтов в json-формате 
            jsonData = jsonService.Serialize(conflicts);

            if (HasError()) return;


            // сохранение конфликтов
            dataConnector.SaveData(jsonData);
        }

        /// <summary>
        /// Возвращает наличие ошибки в процессе
        /// </summary>
        /// <returns>Наличие ошибки в процессе</returns>
        private bool HasError()
        {
            return !string.IsNullOrWhiteSpace(_logger.GetLog());
        }
    }
}