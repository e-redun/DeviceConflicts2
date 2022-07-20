using System.Data;

namespace CommonLib.Services
{
    /// <summary>
    /// Коннектор с БД MsSql
    /// </summary>
    public class MsSqlConnector : IDataConnector
    {
        private const string db = "msSql";

        // Логгер
        private ILogger _logger;


        /// <summary>
        /// Коннектор с БД MsSql
        /// </summary>
        public MsSqlConnector(ILogger logger)
        {
            _logger = logger;
        }


        public string ReadData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConString(db)))
            {
                return "";
            }
        }

        public void SaveData(string jsonData)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConString(db)))
            {

            }
        }
    }
}
