using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ISocialMediaIconService:IGenericService<SocialMediaIcon>
    {
        List<SocialMediaIcon> GetByUserId(int id);
    }
}
