using CommonLib.Enums;

namespace CommonLib.Services
{
    public class ConnectorFactory
    {
        public static IDataConnector CreateConnector(ConnectionTypes connType, ILogger logger)
        {
            IDataConnector output = null;

            switch (connType)
            {
                case ConnectionTypes.File:
                    output = new FileConnector(logger);
                    break;

                case ConnectionTypes.MsSql:
                    output = new MsSqlConnector(logger);
                    break;
            }

            return output;
        }
    }
}
