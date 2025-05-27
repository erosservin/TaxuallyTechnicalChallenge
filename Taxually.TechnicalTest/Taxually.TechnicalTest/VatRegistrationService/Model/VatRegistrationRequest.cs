using Taxually.TechnicalTest.VatRegistrationService.Utility;

namespace Taxually.TechnicalTest.VatRegistrationService.Model
{
    public class VatRegistrationRequest
    {
        public string? CompanyName { get; set; }
        public string? CompanyId { get; set; }
        public SupportedCountryCodesEnum Country { get; set; }
    }
}