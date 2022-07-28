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
    public class DpSocialMediaRepository : DpGenericRepository<SocialMediaIcon>, IDpSocialMediaRepository
    {
        private readonly IDbConnection _db;
        public DpSocialMediaRepository(IDbConnection connection) : base(connection)
        {
            _db = connection; 
        }

        public List<SocialMediaIcon> GetByUserId(int id)
        {
            return _db.Query<SocialMediaIcon>("select * from SocialMediaIcons where AppUserId=@id", new
            {
                id = id
            }).ToList();
        }
    }
}
