﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RenovationWorkRepository : GenericRepository<RenovationWork>
    {
        public RenovationWorkRepository(DbContext context) : base(context)
        {

        }

    }
}
