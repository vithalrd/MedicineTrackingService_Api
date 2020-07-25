namespace MedicineTrackingDtos
{
    /// <summary>
    /// Common Api Response
    /// </summary>
    public class ApiResponse
    {
        public string ErrorInfo { get; set; }
        public string ExtendedInfo { get; set; }
        public bool IsSuccess { get; set; }
    }
}