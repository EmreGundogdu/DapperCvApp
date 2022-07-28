using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SocialMediaIconManager : GenericManager<SocialMediaIcon>, ISocialMediaIconService
    {
        private readonly IGenericRepository<SocialMediaIcon> _socialMediaIconRepository;
        private readonly ISocialMediaIconService _socialMediaIconService;

        public SocialMediaIconManager(IGenericRepository<SocialMediaIcon> socialMediaIconRepository, ISocialMediaIconService socialMediaIconService) : base(socialMediaIconRepository)
        {
            _socialMediaIconRepository = socialMediaIconRepository;
            _socialMediaIconService = socialMediaIconService;
        }

        public List<SocialMediaIcon> GetByUserId(int id)
        {
            return _socialMediaIconService.GetByUserId(id);
        }
    }
}
