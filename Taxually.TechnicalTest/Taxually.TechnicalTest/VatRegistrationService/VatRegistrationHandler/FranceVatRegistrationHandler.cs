using System.Text;
using Taxually.TechnicalTest.VatRegistrationService.Model;
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

    public Task HandleRequestAsync(VatRegistrationRequest request)
    {
        // France requires an excel spreadsheet to be uploaded to register for a VAT number
        var csvBuilder = new StringBuilder();
        csvBuilder.AppendLine("CompanyName,CompanyId");
        csvBuilder.AppendLine($"{request.CompanyName}{request.CompanyId}");
        var csv = Encoding.UTF8.GetBytes(csvBuilder.ToString());
        // Queue file to be processed
        return taxuallyQueueClient.EnqueueAsync("vat-registration-csv", csv);
    }
}