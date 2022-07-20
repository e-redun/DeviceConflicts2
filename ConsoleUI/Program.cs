using CommonLib.Services;
using System;

namespace DeviceConflicts
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessConflicts(args);
        }

        private static void ProcessConflicts(string[] args)
        {
            ILogger logger = new Logger();

            IConflictService conflictService = new ConflictService(logger);

            conflictService.Process();

            if (string.IsNullOrWhiteSpace(logger.GetLog()))
            {
                Console.WriteLine("Обработка закончена успешно.");
            }
            else
            {
                Console.WriteLine("Обработка закончена с ошибками.");
                Console.WriteLine(logger.GetLog());
            }
        }
    }
}