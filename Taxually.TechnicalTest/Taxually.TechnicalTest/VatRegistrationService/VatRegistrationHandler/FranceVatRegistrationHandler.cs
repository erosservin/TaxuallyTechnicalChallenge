using Taxually.TechnicalTest.VatRegistrationService.Entity;
using Taxually.TechnicalTest.VatRegistrationService.Utility;

namespace Taxually.TechnicalTest.VatRegistrationService.VatRegistrationHandler;
public class FranceVatRegistrationHandler : IVatRegistrationHandler
{
    private readonly ITaxuallyQueueClient taxuallyQueueClient;

    public FranceVatRegistrationHandler(ITaxuallyQueueClient taxuallyQueueClient)
    {
        this.taxuallyQueueClient = taxuallyQueueClient;
    }

    public SupportedCountryCodesEnum CountryCode => SupportedCountryCodesEnum.FR;

    public Task HandleRequest(VatRegistrationRequest request)
    {
        throw new NotImplementedException();
    }
}