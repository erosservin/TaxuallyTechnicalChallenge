using Taxually.TechnicalTest.VatRegistrationService.Utility;

namespace Taxually.TechnicalTest.Tests.VatRegistrationService.Utility;

[TestFixture]
public class TaxuallyQueueClientTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void PostAsyncShouldCompleteSuccessfully()
    {
        var queueClient = new TaxuallyQueueClient();
        Task result = queueClient.EnqueueAsync("Mock Queue name", new object());
        Assert.That(result.IsCompleted, Is.True);
    }
}
