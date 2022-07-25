using DTO.Interfaces;

namespace DTO.DTOs.CertificationDtos
{
    public class CertificationListDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
