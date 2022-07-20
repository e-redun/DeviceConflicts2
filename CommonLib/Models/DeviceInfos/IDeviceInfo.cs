namespace CommonLib.Models
{
    /// <summary>
    /// Интерфейс Информации о устройстве
    /// </summary>
    public interface IDeviceInfo
    {
        /// <summary>
        /// Устройство
        /// </summary>
        Device Device { get; set; }

        /// <summary>
        /// Бригада
        /// </summary>
        Brigade Brigade { get; set; }
    }
}