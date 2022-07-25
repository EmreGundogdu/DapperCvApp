using DTO.Interfaces;

namespace DTO.DTOs.AppUserDtos
{
    public class AppUserPasswordDto : IDto
    {
        public int Id { get; set; }
        public string Password { get; set; }
    }
}
