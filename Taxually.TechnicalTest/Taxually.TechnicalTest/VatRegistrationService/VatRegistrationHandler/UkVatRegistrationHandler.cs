using Taxually.TechnicalTest.VatRegistrationService.Model;
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

    public Task HandleRequestAsync(VatRegistrationRequest request)
    {
        return taxuallyHttpClient.PostAsync("https://api.uktax.gov.uk", request);
    }
}