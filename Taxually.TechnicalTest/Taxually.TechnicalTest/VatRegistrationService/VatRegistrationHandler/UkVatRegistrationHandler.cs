using Taxually.TechnicalTest.VatRegistrationService.Model;
using Taxually.TechnicalTest.VatRegistrationService.Utility;

namespace Taxually.TechnicalTest.VatRegistrationService.VatRegistrationHandler;
public class UkVatRegistrationHandler : IVatRegistrationHandler
{
    private readonly ITaxuallyHttpClient taxuallyHttpClient;
    private readonly IConfiguration configuration;

    public UkVatRegistrationHandler(ITaxuallyHttpClient taxuallyHttpClient, IConfiguration configuration)
    {
        this.taxuallyHttpClient = taxuallyHttpClient;
        this.configuration = configuration;
    }

    public SupportedCountryCodesEnum CountryCode => SupportedCountryCodesEnum.GB;

    public Task HandleRequestAsync(VatRegistrationRequest request)
    {
        return taxuallyHttpClient.PostAsync(configuration["VatRegistrationHandler:UK:TaxRegistryURL"], request);
    }
}