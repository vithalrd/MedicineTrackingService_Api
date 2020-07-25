using MedicineTrackingDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicineTrackingRepository
{
    public interface IMedicineQueryRepository
    {
        Task<List<MedicineInfoDto>> GetMedicineInfo(string searchText);
    }
}
