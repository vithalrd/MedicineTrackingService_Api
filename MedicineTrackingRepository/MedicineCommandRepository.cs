using MedicineTrackingDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicineTrackingRepository
{
    /// <summary>
    /// Medicine Command Repository for Upsert
    /// </summary>
    public class MedicineCommandRepository : IMedicineCommandRepository
    {
        public Task<List<MedicineInfoDto>> AddNewMedicine(MedicineInfoDto medicineDto)
        {
            PrepareMedicineData.MedicineList.Add(medicineDto);

            return Task.FromResult(PrepareMedicineData.MedicineList);
        }
    }
}