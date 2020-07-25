using System;

namespace MedicineTrackingDtos
{
    public class MedicineInfoDto
    {
        public string FullName { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Expiry { get; set; }
        public string Notes { get; set; }
    }


}