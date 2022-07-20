namespace CommonLib.Models
{
    /// <summary>
    /// Информация о устройстве
    /// </summary>
    public class DeviceInfo : IDeviceInfo
    {
        /// <summary>
        /// Устройство
        /// </summary>
        public Device Device { get; set; }

        /// <summary>
        /// Бригада
        /// </summary>
        public Brigade Brigade { get; set; }
    }
}