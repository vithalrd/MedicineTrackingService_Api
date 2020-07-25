using MedicineTrackingDtos;
using System;
using System.Collections.Generic;

namespace MedicineTrackingRepository
{
    /// <summary>
    /// Prepare Medicine sample data
    /// </summary>
    public class PrepareMedicineData
    {
        public static List<MedicineInfoDto> MedicineList = new List<MedicineInfoDto>();

        public static List<MedicineInfoDto> GetMedicines()
        {
            return new List<MedicineInfoDto>
            {
                new MedicineInfoDto
                {
                    FullName = "Crosin",
                    Brand = "Cipla",
                    Expiry = DateTime.Now.AddMonths(2),
                    Price = 200,
                    Quantity = 10
                },
                new MedicineInfoDto
                {
                    FullName = "Sinarest",
                    Brand = "Cipla",
                    Expiry = DateTime.Now.AddDays(15),
                    Price = 120,
                    Quantity = 30
                },
                new MedicineInfoDto
                {
                    FullName = "Coldact",
                    Brand = "Zydus",
                    Expiry = DateTime.Now.AddMonths(3),
                    Price = 59,
                    Quantity = 5
                },
                new MedicineInfoDto
                {
                    FullName = "Zandu",
                    Brand = "Zydus",
                    Expiry = DateTime.Now.AddMonths(3),
                    Price = 670,
                    Quantity = 8
                },
                new MedicineInfoDto
                {
                    FullName = "Move",
                    Brand = "Zydus",
                    Expiry = DateTime.Now.AddDays(2),
                    Price = 450,
                    Quantity = 200
                }
            };
        }
    }
}