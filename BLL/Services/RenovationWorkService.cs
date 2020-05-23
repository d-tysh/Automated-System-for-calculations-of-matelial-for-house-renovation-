using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class RenovationWorkService : AGenericService<RenovationWork>
    {
        public RenovationWorkService(IGenericRepository<RenovationWork> repository) : base(repository)
        {

        }

    }
}
