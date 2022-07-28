using AutoMapper;
using Business.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Web.TagHelpers
{
    [HtmlTargetElement("GetIcons")]
    public class SocialMediaIconTagHelper : TagHelper
    {
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;
        private readonly ISocialMediaIconService _socialMediaService;
        public SocialMediaIconTagHelper(IAppUserService appUserService, IMapper mapper, ISocialMediaIconService socialMediaService)

        {
            _appUserService = appUserService;
            _mapper = mapper;
            _socialMediaService = socialMediaService;
        }
        public int AppUserId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var icons = _socialMediaService.GetByUserId(AppUserId);
            string data = $"<div class='social - icons'>";
            foreach (var item in icons)
            {
                data += $@">
                <a class='social-icon pr-2' href='{item.Link}!'><i class='{item.Icon}'></i></a>";
            }
            data += "</div>";
            output.Content.SetHtmlContent(data);
        }
    }
}
