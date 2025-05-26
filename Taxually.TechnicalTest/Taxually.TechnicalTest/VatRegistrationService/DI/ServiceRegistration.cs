using Taxually.TechnicalTest.VatRegistrationService.Utility;
using Taxually.TechnicalTest.VatRegistrationService.VatRegistrationHandler;

namespace Taxually.TechnicalTest.VatRegistrationService.DI;

public static class ServiceRegistration
{
    public static IServiceCollection AddVatRegistrationService(this IServiceCollection services)
    {
        // VatRegistrationService
        services.AddTransient<IVatRegistrationService, VatRegistrationService>();

        // VatRegistrationHandlers
        services.AddTransient<IVatRegistrationHandlerResolver, VatRegistrationHandlerResolver>();
        services.AddTransient<IVatRegistrationHandler, UkVatRegistrationHandler>();
        services.AddTransient<IVatRegistrationHandler, FranceVatRegistrationHandler>();
        services.AddTransient<IVatRegistrationHandler, GermanyVatRegistrationHandler>();

        // Utility
        services.AddTransient<ITaxuallyHttpClient, TaxuallyHttpClient>();
        services.AddTransient<ITaxuallyQueueClient, TaxuallyQueueClient>();

        return services;
    }
}