using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CalculationHistoryRepository : GenericRepository<CalculationHistory>
    {
        public CalculationHistoryRepository(DbContext context) : base(context)
        {

        }

    }
}
