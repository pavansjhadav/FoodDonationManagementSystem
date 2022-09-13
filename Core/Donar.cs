﻿using BloodDonationManagementSystem.Data_Access;
using BloodDonationManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationManagementSystem.Core
{
    public class Donar : IDonar
    {
        readonly DonarContext _donarContext;
        public Donar(DonarContext donarContext)
        {
            _donarContext = donarContext;
        }
        public void AddDonar(SchoolModel schoolModel)
        {
            _donarContext.schoolModels.Add(schoolModel);
            _donarContext.SaveChanges();
        }

        public IEnumerable<SchoolModel> GetAll()
        {
            return _donarContext.schoolModels.ToList();
        }
    }
}
