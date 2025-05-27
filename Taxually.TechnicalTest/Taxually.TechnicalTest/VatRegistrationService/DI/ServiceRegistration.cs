using Taxually.TechnicalTest.VatRegistrationService.MappingProfile;
using Taxually.TechnicalTest.VatRegistrationService.Utility;
using Taxually.TechnicalTest.VatRegistrationService.VatRegistrationHandler;

namespace Taxually.TechnicalTest.VatRegistrationService.DI;

public static class ServiceRegistration
{
    public static IServiceCollection AddVatRegistrationService(this IServiceCollection services)
    {
        // VatRegistrationService
        services.AddScoped<IVatRegistrationService, VatRegistrationService>();
        services.AddAutoMapper(typeof(VatRegistrationServiceMappingProfile));

        // VatRegistrationHandlers
        services.AddScoped<IVatRegistrationHandlerResolver, VatRegistrationHandlerResolver>();
        services.AddScoped<IVatRegistrationHandler, UkVatRegistrationHandler>();
        services.AddScoped<IVatRegistrationHandler, FranceVatRegistrationHandler>();
        services.AddScoped<IVatRegistrationHandler, GermanyVatRegistrationHandler>();

        // Utility
        services.AddScoped<ITaxuallyHttpClient, TaxuallyHttpClient>();
        services.AddScoped<ITaxuallyQueueClient, TaxuallyQueueClient>();

        return services;
    }
}