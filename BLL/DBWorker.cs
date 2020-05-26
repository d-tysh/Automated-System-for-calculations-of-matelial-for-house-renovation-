using BLL.Services;
using DAL;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DBWorker
    {
        ASModel context;
        public UserService UserService { get; }
        public RenovationWorkService RenovationWorkService { get; }
        public TypesMaterialService TypesMaterialService { get; }
        public CalculationHistoryService CalculationHistoryService { get; }


        public DBWorker()
        {
            context = new ASModel();
            UserService = new UserService(new UserRepository(context));
            RenovationWorkService = new RenovationWorkService(new RenovationWorkRepository(context));
            TypesMaterialService = new TypesMaterialService(new TypesMaterialRepository(context));
            CalculationHistoryService = new CalculationHistoryService(new CalculationHistoryRepository(context));
        }

        public int UserId { get; set; }

    }
}
