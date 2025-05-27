using AutoMapper;
using Taxually.TechnicalTest.VatRegistrationService.DTO;
using Taxually.TechnicalTest.VatRegistrationService.Model;
using Taxually.TechnicalTest.VatRegistrationService.Utility;

namespace Taxually.TechnicalTest.VatRegistrationService.MappingProfile;

public class VatRegistrationServiceMappingProfile : Profile
{
    public VatRegistrationServiceMappingProfile()
    {
        CreateMap<VatRegistrationRequestDto, VatRegistrationRequest>()
            .ForMember(dest => dest.Country, opt => opt.MapFrom(src => ParseEnum<SupportedCountryCodesEnum>(src.Country)));
    }

    private static TEnum ParseEnum<TEnum>(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException(nameof(value));
        }
        return (TEnum)Enum.Parse(typeof(TEnum), value);
    }
}