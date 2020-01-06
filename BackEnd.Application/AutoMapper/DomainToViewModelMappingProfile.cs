namespace BackEnd.Application.AutoMapper
{
    using BackEnd.Application.ViewModel;
    using BackEnd.Domain.Models;
    using global::AutoMapper;

    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            this.CreateMap<Seguradora, SeguradoraViewModel>().MaxDepth(1);
        }
    }
}
