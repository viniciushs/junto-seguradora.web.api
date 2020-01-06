namespace BackEnd.Application.ViewModel
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class SeguradoraViewModel : BaseViewModel
    {
        /// <summary>
        ///     CPF da Seguradora
        /// </summary>
        [MaxLength(14)]
        [DisplayName("Cnpj")]
        public string Cnpj { get; set; }

        /// <summary>
        ///     Nome da Seguradora
        /// </summary>
        [MaxLength(256)]
        [DisplayName("Nome")]
        public string Nome { get; set; }
    }
}
