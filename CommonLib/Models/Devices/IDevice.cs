namespace CommonLib.Models
{
    /// <summary>
    /// Интерфейс устройства
    /// </summary>
    public interface IDevice
    {
        /// <summary>
        /// Серийный номер
        /// </summary>
        string SerialNumber { get; set; }

        /// <summary>
        /// Флаг режима Online
        /// </summary>
        bool IsOnline { get; set; }
    }
}