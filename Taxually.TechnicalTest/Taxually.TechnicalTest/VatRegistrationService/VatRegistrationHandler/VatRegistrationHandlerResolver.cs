using Taxually.TechnicalTest.VatRegistrationService.Utility;

namespace Taxually.TechnicalTest.VatRegistrationService.VatRegistrationHandler;

public class VatRegistrationHandlerResolver : IVatRegistrationHandlerResolver
{
    private readonly Dictionary<SupportedCountryCodesEnum, IVatRegistrationHandler> vatRegistrationHandlers;
    public VatRegistrationHandlerResolver(IEnumerable<IVatRegistrationHandler> vatRegistrationHandlers)
    {
        this.vatRegistrationHandlers = vatRegistrationHandlers.ToDictionary( x => x.CountryCode, x => x);
    }

    public IVatRegistrationHandler Resolve(SupportedCountryCodesEnum countryCode)
    {
        if (vatRegistrationHandlers.TryGetValue(countryCode, out var handler))
        {
            return handler;
        }
        else
        {
            throw new ArgumentException($"No {nameof(IVatRegistrationHandler)} found for the given argument.", nameof(countryCode));
        }
    }
}