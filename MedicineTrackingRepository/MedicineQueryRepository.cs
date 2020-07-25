using MedicineTrackingDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineTrackingRepository
{
    /// <summary>
    /// Medicine Query Repository for Read
    /// </summary>
    public class MedicineQueryRepository : IMedicineQueryRepository
    {
        public Task<List<MedicineInfoDto>> GetMedicineInfo(string searchText)
        {
            var medicines = PrepareMedicineData.MedicineList;

            if (!string.IsNullOrEmpty(searchText))
            {
                medicines = medicines
                   .Where(x => x.FullName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            return Task.FromResult(medicines);
        }


    }
}