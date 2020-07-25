using System.Collections.Generic;

namespace MedicineTrackingDtos
{
    public class Medicines : ApiResponse
    {
        public List<MedicineInfoDto> MedicineInfoDto { get; set; }
    }
}