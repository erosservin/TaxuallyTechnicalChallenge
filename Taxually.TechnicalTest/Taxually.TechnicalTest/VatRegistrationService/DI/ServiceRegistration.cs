using Taxually.TechnicalTest.VatRegistrationService.Utility;

namespace Taxually.TechnicalTest.VatRegistrationService.DI;

public static class ServiceRegistration
{
    public static IServiceCollection AddVatRegistrationService(this IServiceCollection services)
    {
        // VatRegistrationService
        services.AddTransient<IVatRegistrationService, VatRegistrationService>();



        // Utility
        services.AddTransient<ITaxuallyHttpClient, TaxuallyHttpClient>();
        services.AddTransient<ITaxuallyQueueClient, TaxuallyQueueClient>();

        return services;
    }
}