﻿using FoodTrucks.Provider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrucks.Provider.Interface
{
    public interface ITruckInfo
    {
        Task<List<TruckInfoModel>> GetTruckList();
        Task<int> Add(TruckInfoModel truckInfoModel);
    }
}
