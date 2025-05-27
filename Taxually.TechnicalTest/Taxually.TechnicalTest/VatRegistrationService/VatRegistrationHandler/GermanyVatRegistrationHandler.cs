using Taxually.TechnicalTest.VatRegistrationService.Model;
using Taxually.TechnicalTest.VatRegistrationService.Utility;

namespace Taxually.TechnicalTest.VatRegistrationService.VatRegistrationHandler;
public class GermanyVatRegistrationHandler : IVatRegistrationHandler
{
    private readonly ITaxuallyQueueClient taxuallyQueueClient;

    public GermanyVatRegistrationHandler(ITaxuallyQueueClient taxuallyQueueClient)
    {
        this.taxuallyQueueClient = taxuallyQueueClient;
    }

    public SupportedCountryCodesEnum CountryCode => SupportedCountryCodesEnum.DE;

    public Task HandleRequest(VatRegistrationRequest request)
    {
        throw new NotImplementedException();
    }
}