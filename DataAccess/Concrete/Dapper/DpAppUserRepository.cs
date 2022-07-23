using Dapper;
using DataAccess.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Dapper
{
    public class DpAppUserRepository : DpGenericRepository<AppUser>, IAppUserRepository
    {
        private readonly IDbConnection _dbConnection;

        public DpAppUserRepository(IDbConnection dbConnection) : base(dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public bool CheckUser(string userName, string password)
        {
            var user = _dbConnection.QueryFirstOrDefault<AppUser>("select * from AppUsers where UserName=@userName and Password=@password");
            return user != null;
        }
    }
}
