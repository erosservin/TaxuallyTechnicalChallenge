using Taxually.TechnicalTest.VatRegistrationService.Entity;
using Taxually.TechnicalTest.VatRegistrationService.Utility;

namespace Taxually.TechnicalTest.VatRegistrationService.VatRegistrationHandler;
public class UkVatRegistrationHandler : IVatRegistrationHandler
{
    private readonly ITaxuallyHttpClient taxuallyHttpClient;

    public UkVatRegistrationHandler(ITaxuallyHttpClient taxuallyHttpClient)
    {
        this.taxuallyHttpClient = taxuallyHttpClient;
    }

    public SupportedCountryCodesEnum CountryCode => SupportedCountryCodesEnum.GB;

    public Task HandleRequest(VatRegistrationRequest request)
    {
        throw new NotImplementedException();
    }
}