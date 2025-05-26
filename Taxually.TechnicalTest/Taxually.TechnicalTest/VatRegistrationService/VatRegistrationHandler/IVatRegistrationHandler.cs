using Taxually.TechnicalTest.VatRegistrationService.Entity;
using Taxually.TechnicalTest.VatRegistrationService.Utility;

namespace Taxually.TechnicalTest.VatRegistrationService.VatRegistrationHandler;

public interface IVatRegistrationHandler
{
    SupportedCountryCodesEnum CountryCode { get; }
    Task HandleRequest(VatRegistrationRequest request);
}