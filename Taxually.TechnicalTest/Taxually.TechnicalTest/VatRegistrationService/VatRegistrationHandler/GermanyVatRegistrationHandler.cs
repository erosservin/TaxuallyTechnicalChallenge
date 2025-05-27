using System.Xml.Serialization;
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

    public Task HandleRequestAsync(VatRegistrationRequest request)
    {
        // Germany requires an XML document to be uploaded to register for a VAT number
        using var stringwriter = new StringWriter();
        var serializer = new XmlSerializer(typeof(VatRegistrationRequest));
        serializer.Serialize(stringwriter, this);
        var xml = stringwriter.ToString();
        var xmlQueueClient = new TaxuallyQueueClient();
        // Queue xml doc to be processed
        return xmlQueueClient.EnqueueAsync("vat-registration-xml", xml);
    }
}