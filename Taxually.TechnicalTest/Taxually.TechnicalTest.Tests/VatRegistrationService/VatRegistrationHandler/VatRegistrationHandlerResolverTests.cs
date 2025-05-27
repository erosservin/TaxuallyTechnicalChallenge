using Taxually.TechnicalTest.VatRegistrationService.Utility;
using Taxually.TechnicalTest.VatRegistrationService.VatRegistrationHandler;

namespace Taxually.TechnicalTest.Tests.VatRegistrationService.VatRegistrationHandler;

[TestFixture]
public class VatRegistrationHandlerResolverTests
{
    [Test]
    public void ShouldResolveVatRegistrationHandler()
    {
        var expectedRegistrationHandler = new UkVatRegistrationHandler(new TaxuallyHttpClient());
        IEnumerable<IVatRegistrationHandler> vatRegistrationHandlers = [expectedRegistrationHandler];

        var handler = new VatRegistrationHandlerResolver(vatRegistrationHandlers);

        var resolvedRegistrationHandler = handler.Resolve(SupportedCountryCodesEnum.GB);
        Assert.That(resolvedRegistrationHandler, Is.SameAs(expectedRegistrationHandler));
    }
    
    [Test]
    public void VatRegistrationHandlerResolverCannotBeConstructed_ThrowsArgumentException()
    {
        IEnumerable<IVatRegistrationHandler> vatRegistrationHandlers = [];
        
        Assert.Throws<ArgumentException>(() => new VatRegistrationHandlerResolver(vatRegistrationHandlers));
    }
}