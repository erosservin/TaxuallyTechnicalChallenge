using Taxually.TechnicalTest.VatRegistrationService.Utility;

namespace Taxually.TechnicalTest.Tests.VatRegistrationService.Utility;

[TestFixture]
public class TaxuallyHttpClientTests
{
    [Test]
    public void PostAsyncShouldCompleteSuccessfully()
    {
        var httpClient = new TaxuallyHttpClient();
        Task result = httpClient.PostAsync("Mock URL", new object());
        Assert.That(result.IsCompleted, Is.True);
    }
}
