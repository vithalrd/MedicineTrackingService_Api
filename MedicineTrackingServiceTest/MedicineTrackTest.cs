using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MedicineTrackingDtos;
using MedicineTrackingRepository;
using MedicineTrackingService.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MedicineTrackingServiceTest
{
    [TestClass]
    public class MedicineTrackTest
    {
        public static Task<List<MedicineInfoDto>> MedicineList = null;

        public MedicineTrackTest()
        {
            MedicineList = PrepareTestData.GetMedicines();
        }


        [TestMethod]
        public void SearchMedicine_Test()
        {
            string searchText = "Medicine";
           
            var medicineRepoQuery = new Mock<IMedicineQueryRepository>();
            medicineRepoQuery.Setup(x => x.GetMedicineInfo(searchText)).Returns(MedicineList);

            var medicineController = new MedicineTrackController(medicineRepoQuery.Object, null);

            var medicines = medicineController.GetMedicinesAsync(searchText).Result;
            Assert.AreEqual(medicines.MedicineInfoDto.Count, 5);
        }

        [TestMethod]
        public void AddNewMedicine_Test()
        {
            MedicineInfoDto dto = new MedicineInfoDto
            {
                Quantity = 100,
                Brand = "Xyz",
                Expiry = DateTime.Now.AddDays(33),
                FullName = "Medicine 6",
                Price = 234,
                Notes = "Hello"

            };
            MedicineList.Result.Add(dto);
            var medicineRepoCommand = new Mock<IMedicineCommandRepository>();
            medicineRepoCommand.Setup(x => x.AddNewMedicine(dto)).Returns(MedicineList);

            var medicineController = new MedicineTrackController(null, medicineRepoCommand.Object);

            var newmedicines = medicineController.AddNewMedicine(dto).Result;
            Assert.AreEqual(newmedicines.MedicineInfoDto.Count, 6);
        }
    }

}
