using Taxually.TechnicalTest.VatRegistrationService.DTO;
using Taxually.TechnicalTest.VatRegistrationService.VatRegistrationHandler;

namespace Taxually.TechnicalTest.VatRegistrationService;

public class VatRegistrationService : IVatRegistrationService
{
    private readonly IVatRegistrationHandlerResolver vatRegistrationHandlerResolver;

    public VatRegistrationService(IVatRegistrationHandlerResolver vatRegistrationHandlerResolver)
    {
        this.vatRegistrationHandlerResolver = vatRegistrationHandlerResolver;
    }

    public Task RegisterAsync(VatRegistrationRequestDto request)
    {
        // Resolve handler
        // Map to VatRegistrationRequest
        // vatRegistrationHandlerResolver.Resolve(request.CountryCode).HandleRequest(request);
        throw new NotImplementedException();
        
        //     switch (request.Country)
        // {
        //     case "GB":
        //         // UK has an API to register for a VAT number
        //         var httpClient = new TaxuallyHttpClient();
        //         return httpClient.PostAsync("https://api.uktax.gov.uk", request).Wait();
        //         break;
        //     case "FR":
        //         // France requires an excel spreadsheet to be uploaded to register for a VAT number
        //         var csvBuilder = new StringBuilder();
        //         csvBuilder.AppendLine("CompanyName,CompanyId");
        //         csvBuilder.AppendLine($"{request.CompanyName}{request.CompanyId}");
        //         var csv = Encoding.UTF8.GetBytes(csvBuilder.ToString());
        //         var excelQueueClient = new TaxuallyQueueClient();
        //         // Queue file to be processed
        //         excelQueueClient.EnqueueAsync("vat-registration-csv", csv).Wait();
        //         break;
        //     case "DE":
        //         // Germany requires an XML document to be uploaded to register for a VAT number
        //         using (var stringwriter = new StringWriter())
        //         {
        //             var serializer = new XmlSerializer(typeof(VatRegistrationRequestDto));
        //             serializer.Serialize(stringwriter, this);
        //             var xml = stringwriter.ToString();
        //             var xmlQueueClient = new TaxuallyQueueClient();
        //             // Queue xml doc to be processed
        //             xmlQueueClient.EnqueueAsync("vat-registration-xml", xml).Wait();
        //         }
        //         break;
        //     default:
        //         throw new Exception("Country not supported");

    }
}