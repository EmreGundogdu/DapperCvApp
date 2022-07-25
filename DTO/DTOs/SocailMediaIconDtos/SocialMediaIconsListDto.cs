using DTO.Interfaces;

namespace DTO.DTOs.SocailMediaIconDtos
{
    public class SocialMediaIconsListDto : IDto
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public int AppUserId { get; set; }
    }
}
