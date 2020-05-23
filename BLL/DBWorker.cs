using BLL.Services;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DBWorker
    {
        DBModel context;
        public UserService UserService { get; }
        public RenovationWorkService RenovationWorkService { get; }
        public TypesMaterialService TypesMaterialService { get; }

        public DBWorker()
        {
            context = new DBModel();
            UserService = new UserService(new UserRepository(context));
            RenovationWorkService = new RenovationWorkService(new RenovationWorkRepository(context));
            TypesMaterialService = new TypesMaterialService(new TypesMaterialRepository(context));
        }

        /*public Close()
        {
            context.Database.Connection.
        }
        */
    }
}
