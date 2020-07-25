using MedicineTrackingDtos;
using MedicineTrackingRepository;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace MedicineTrackingService.Controllers
{
    /// <summary>
    /// Medicine Track Controller
    /// </summary>
    public class MedicineTrackController : ApiController
    {
        private readonly IMedicineQueryRepository medicineQueryRepository;
        private readonly IMedicineCommandRepository medicineCommandRepository;

        public MedicineTrackController(IMedicineQueryRepository medicineQueryRepository,
            IMedicineCommandRepository medicineCommandRepository)
        {
            this.medicineQueryRepository = medicineQueryRepository;
            this.medicineCommandRepository = medicineCommandRepository;
        }

        /// <summary>
        /// Get list of Medicine by Name
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Medicines> GetMedicinesAsync(string searchText = null)
        {
            Medicines medicineResponse = new Medicines();
            try
            {
                var medicines = await medicineQueryRepository.GetMedicineInfo(searchText);
                medicineResponse.MedicineInfoDto = medicines;
                medicineResponse.ExtendedInfo = string.Empty;
                medicineResponse.IsSuccess = true;
            }
            catch (Exception ex)
            {
                medicineResponse.MedicineInfoDto = null;
                medicineResponse.ExtendedInfo = "Unable to fetch the medicine information";
                medicineResponse.ExtendedInfo = ex.Message;
                medicineResponse.IsSuccess = false;
            }
            return medicineResponse;

        }

        /// <summary>
        /// Add new Medicine
        /// </summary>
        /// <param name="medicineDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Medicines> AddNewMedicine(MedicineInfoDto medicineDto)
        {
            Medicines medicineResponse = new Medicines();
            try
            {
                var medicines = await medicineCommandRepository.AddNewMedicine(medicineDto);
                medicineResponse.MedicineInfoDto = medicines;
                medicineResponse.ExtendedInfo = string.Empty;
                medicineResponse.IsSuccess = true;
            }
            catch (Exception ex)
            {
                medicineResponse.MedicineInfoDto = null;
                medicineResponse.ExtendedInfo = "Unable to add the medicine information";
                medicineResponse.ExtendedInfo = ex.Message;
                medicineResponse.IsSuccess = false;
            }
            return medicineResponse;
        }
    }
}
