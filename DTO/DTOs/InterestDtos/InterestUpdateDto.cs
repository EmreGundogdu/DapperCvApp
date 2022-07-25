using DTO.Interfaces;

namespace DTO.DTOs.InterestDtos
{
    public class InterestAddDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
