﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CalculationHistoryService : AGenericService<CalculationHistory>
    {
        public CalculationHistoryService(IGenericRepository<CalculationHistory> repository) : base(repository)
        {

        }

    }
}
