namespace BackEnd.Application.AutoMapper
{
    using BackEnd.Application.ViewModel;
    using BackEnd.Domain.Models;
    using global::AutoMapper;
    using System;

    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            this.CreateMap<SeguradoraViewModel, Seguradora>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome.ToTitleCase()))
                .ForMember(dest => dest.Cnpj, opt => opt.MapFrom(src => src.Cnpj.ReplaceNonDigits()));
        }
    }
}
