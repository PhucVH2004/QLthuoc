﻿using PharmacySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacySystem.Repositories.MedicineRepository
{
    public interface IMedicineRepository
    {
        int AddMedicine(MedicineModel medicine);
        void DeleteMedicine(int id);
        int GetMedicineIdByEarliestExpiry(string medicineCode);
        List<MedicineProductModel> GetAllMedicineProduct();
        List<MedicineProductModel> GetMedicineProductsByGroupCode(string groupCode);
        List<MedicineProductModel> GetMedicineProductsByNameAndGroup(string searchText, string groupCode);

    }
}
