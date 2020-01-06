using AutoMapper;
using BackEnd.Application.Filters;
using BackEnd.Application.Interfaces;
using BackEnd.Application.ViewModel;
using BackEnd.Domain.Models;
using BackEnd.Infra.Data.Interfaces;

namespace BackEnd.Application.Services
{
    /// <summary>
    ///     Implementação da <see cref="ISeguradoraAppService"/>.
    /// </summary>
    public class SeguradoraAppService : BaseAppService<SeguradoraViewModel, SeguradoraFilter, Seguradora>, ISeguradoraAppService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeguradoraAppService"/> class.
        ///     Construtor padrão de <see cref="SeguradoraAppService"/>.
        /// </summary>
        /// <param name="uow">
        ///     Contrato do Unit of Work. Veja <see cref="IUnitOfWork"/>.
        /// </param>
        /// <param name="mapper">
        ///     Contrato do AutoMapper. Veja <see cref="IMapper"/>.
        /// </param>
        /// <param name="repository">
        ///     O repositório da entidade Seguradora. Veja <see cref="ISeguradoraRepository"/>.
        /// </param>

        public SeguradoraAppService(
            IUnitOfWork uow,
            IMapper mapper,
            ISeguradoraRepository repository)
            : base(uow, mapper, repository)
        {
        }
    }
}
