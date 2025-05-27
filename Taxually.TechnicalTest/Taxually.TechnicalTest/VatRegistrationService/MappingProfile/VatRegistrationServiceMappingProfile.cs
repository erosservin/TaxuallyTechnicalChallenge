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
#pragma warning disable CS8604 // Possible null reference argument.
        return (TEnum)Enum.Parse(typeof(TEnum), value);
#pragma warning restore CS8604 // Possible null reference argument.
    }
}