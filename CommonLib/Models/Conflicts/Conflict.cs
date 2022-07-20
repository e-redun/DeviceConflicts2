namespace CommonLib.Models
{
    /// <summary>
    /// Конфликт
    /// </summary>
    public class Conflict : IConflict
    {
        /// <summary>
        /// Код бригады
        /// </summary>
        public string BrigadeCode { get; set; }

        /// <summary>
        /// Серийные номера устройств
        /// </summary>
        public string[] DevicesSerials { get; set; }
    }
}