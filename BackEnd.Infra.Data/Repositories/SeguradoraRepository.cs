namespace BackEnd.Infra.Data.Repositories
{
    using BackEnd.Domain.Models;
    using BackEnd.Infra.Data.Contexts;
    using BackEnd.Infra.Data.Interfaces;

    /// <summary>
    ///     Implementação da <see cref="ISeguradoraRepository"/>.
    /// </summary>
    public class SeguradoraRepository : BaseRepository<Seguradora>, ISeguradoraRepository
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SeguradoraRepository"/> class.
        ///     Construtor padrão de <see cref="SeguradoraRepository"/>.
        /// </summary>
        /// <param name="context">
        ///     O contexto do repositório. Veja <see cref="MonliContext"/>.
        /// </param>
        public SeguradoraRepository(BackEndContext context)
            : base(context)
        {
        }
    }
}
