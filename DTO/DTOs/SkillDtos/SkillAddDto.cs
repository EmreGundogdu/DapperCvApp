using DTO.Interfaces;

namespace DTO.DTOs.SkillDtos
{
    public class SkillAddDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
