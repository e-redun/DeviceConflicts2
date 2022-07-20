namespace CommonLib.Models
{
    /// <summary>
    /// Устройство
    /// </summary>
    public class Device : IDevice
    {
        /// <summary>
        /// Серийный номер
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Флаг режима Online
        /// </summary>
        public bool IsOnline { get; set; }
    }
}
