﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TypesMaterialRepository : GenericRepository<TypesMaterial>
    {
        public TypesMaterialRepository(DbContext context) : base(context)
        {

        }
    }
}