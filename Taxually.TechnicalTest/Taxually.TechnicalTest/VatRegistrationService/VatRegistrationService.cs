using AutoMapper;
using Taxually.TechnicalTest.VatRegistrationService.DTO;
using Taxually.TechnicalTest.VatRegistrationService.Model;
using Taxually.TechnicalTest.VatRegistrationService.VatRegistrationHandler;

namespace Taxually.TechnicalTest.VatRegistrationService;

public class VatRegistrationService : IVatRegistrationService
{
    private readonly IVatRegistrationHandlerResolver vatRegistrationHandlerResolver;
    private readonly IMapper vatRegistrationMapper;

    public VatRegistrationService(IVatRegistrationHandlerResolver vatRegistrationHandlerResolver, IMapper vatRegistrationMapper)
    {
        this.vatRegistrationHandlerResolver = vatRegistrationHandlerResolver;
        this.vatRegistrationMapper = vatRegistrationMapper;
    }

    public Task RegisterAsync(VatRegistrationRequestDto request)
    {
        var requestModel = vatRegistrationMapper.Map<VatRegistrationRequest>(request);

        return vatRegistrationHandlerResolver.Resolve(requestModel.Country).HandleRequestAsync(requestModel);
    }
}