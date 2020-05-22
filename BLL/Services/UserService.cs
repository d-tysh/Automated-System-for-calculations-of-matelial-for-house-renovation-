using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : AGenericService<User>
    {
        public UserService(IGenericRepository<User> repository) : base(repository)
        {

        }



    }
}
