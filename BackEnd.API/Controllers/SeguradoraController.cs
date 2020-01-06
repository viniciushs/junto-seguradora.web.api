using BackEnd.Application.Filters;
using BackEnd.Application.Interfaces;
using BackEnd.Application.ViewModel;
using BackEnd.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace BackEnd.API.Controllers
{
    /// <summary>
    ///     Controller de Seguradora.
    /// </summary>
    public class SeguradoraController : BaseController<SeguradoraViewModel, SeguradoraFilter, Seguradora>
    {
        private new readonly ISeguradoraAppService appService;
        private readonly ILogger logger;

        /// <summary>
        ///     Initializes a new instance of the <see cref="SeguradoraController"/> class.
        ///     Contrutor padrão do PessoaController.
        /// </summary>
        /// <param name="appService">Application de serviço</param>
        /// <param name="loggerFactory">Factory de gerenciamento de logs</param>
        public SeguradoraController(
            ISeguradoraAppService appService,
            ILoggerFactory loggerFactory)
            : base(appService)
        {
            this.appService = appService;
            this.logger = loggerFactory.CreateLogger<SeguradoraController>();
        }
    }
}