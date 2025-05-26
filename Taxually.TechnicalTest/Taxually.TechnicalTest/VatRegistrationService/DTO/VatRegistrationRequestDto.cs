using System.ComponentModel.DataAnnotations;

namespace Taxually.TechnicalTest.VatRegistrationService.DTO
{
    public class VatRegistrationRequestDto
    {
        [Required]
        public string? CompanyName { get; set; }
        [Required]
        public string? CompanyId { get; set; }
        [Required]
        public string? Country { get; set; }
    }
}