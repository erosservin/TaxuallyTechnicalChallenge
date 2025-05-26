using Taxually.TechnicalTest.VatRegistrationService.DTO;

namespace Taxually.TechnicalTest.VatRegistrationService;

public interface IVatRegistrationService
{
    Task RegisterAsync(VatRegistrationRequestDto request);
}