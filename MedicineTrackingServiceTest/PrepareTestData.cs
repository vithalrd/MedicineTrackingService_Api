using MedicineTrackingDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineTrackingServiceTest
{
    public  class PrepareTestData
    {
        public static async Task<List<MedicineInfoDto>> GetMedicines()
        {
            return new List<MedicineInfoDto>
            {
                new MedicineInfoDto
                {
                    FullName = "Medicine 1",
                    Brand = "Cipla",
                    Expiry = DateTime.Now.AddMonths(2),
                    Price = 200,
                    Quantity = 10
                },
                new MedicineInfoDto
                {
                    FullName = "Medicine 2",
                    Brand = "Cipla",
                    Expiry = DateTime.Now.AddDays(15),
                    Price = 120,
                    Quantity = 30
                },
                new MedicineInfoDto
                {
                    FullName = "Medicine 3",
                    Brand = "Zydus",
                    Expiry = DateTime.Now.AddMonths(3),
                    Price = 59,
                    Quantity = 5
                },
                new MedicineInfoDto
                {
                    FullName = "Medicine 4",
                    Brand = "Zydus",
                    Expiry = DateTime.Now.AddMonths(3),
                    Price = 670,
                    Quantity = 8
                },
                new MedicineInfoDto
                {
                    FullName = "Medicine 5",
                    Brand = "Zydus",
                    Expiry = DateTime.Now.AddDays(2),
                    Price = 450,
                    Quantity = 200
                }
            };
        }
    }
}
