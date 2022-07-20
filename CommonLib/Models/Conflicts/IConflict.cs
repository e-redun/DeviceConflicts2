namespace CommonLib.Models
{   /// <summary>
    /// Интерфейс Конфликта
    /// </summary>
    public interface IConflict
    {
        /// <summary>
        /// Код бригады
        /// </summary>
        string BrigadeCode { get; set; }

        /// <summary>
        /// Серийные номера устройств
        /// </summary>
        string[] DevicesSerials { get; set; }
    }
}