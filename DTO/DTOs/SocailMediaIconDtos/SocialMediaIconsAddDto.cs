using DTO.Interfaces;

namespace DTO.DTOs.SocailMediaIconDtos
{
    public class SocialMediaIconsAddDto : IDto
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public int AppUserId { get; set; }
    }
}
