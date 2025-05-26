using Taxually.TechnicalTest.VatRegistrationService.Utility;

namespace Taxually.TechnicalTest.VatRegistrationService.VatRegistrationHandler;

public interface IVatRegistrationHandlerResolver
{
    IVatRegistrationHandler Resolve(SupportedCountryCodesEnum countryCode);
}