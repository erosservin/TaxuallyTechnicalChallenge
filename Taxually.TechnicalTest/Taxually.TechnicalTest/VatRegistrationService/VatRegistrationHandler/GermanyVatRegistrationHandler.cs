using System.Xml.Serialization;
using Taxually.TechnicalTest.VatRegistrationService.Model;
using Taxually.TechnicalTest.VatRegistrationService.Utility;

namespace Taxually.TechnicalTest.VatRegistrationService.VatRegistrationHandler;
public class GermanyVatRegistrationHandler : IVatRegistrationHandler
{
    private readonly ITaxuallyQueueClient taxuallyQueueClient;
    private readonly IConfiguration configuration;

    public GermanyVatRegistrationHandler(ITaxuallyQueueClient taxuallyQueueClient, IConfiguration configuration)
    {
        this.taxuallyQueueClient = taxuallyQueueClient;
        this.configuration = configuration;
    }

    public SupportedCountryCodesEnum CountryCode => SupportedCountryCodesEnum.DE;

    public Task HandleRequestAsync(VatRegistrationRequest request)
    {
        // Germany requires an XML document to be uploaded to register for a VAT number
        using var stringwriter = new StringWriter();
        var serializer = new XmlSerializer(typeof(VatRegistrationRequest));
        serializer.Serialize(stringwriter, request);
        var xml = stringwriter.ToString();
        // Queue xml doc to be processed
        return taxuallyQueueClient.EnqueueAsync(configuration["VatRegistrationHandler:DE:QueueName"], xml);
    }
}