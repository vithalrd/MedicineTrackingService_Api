using MedicineTrackingDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicineTrackingRepository
{
    public interface IMedicineCommandRepository
    {
        Task<List<MedicineInfoDto>> AddNewMedicine(MedicineInfoDto medicineDto);
    }
}
