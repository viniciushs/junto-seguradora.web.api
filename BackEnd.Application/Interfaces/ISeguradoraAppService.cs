namespace BackEnd.Application.Interfaces
{
    using BackEnd.Application.Filters;
    using BackEnd.Application.ViewModel;
    using BackEnd.Domain.Models;

    /// <summary>
    ///     Interface de contrato de Seguradora Application Service
    /// </summary>
    public interface ISeguradoraAppService : IBaseAppService<SeguradoraViewModel, SeguradoraFilter, Seguradora>
    {
    }
}
