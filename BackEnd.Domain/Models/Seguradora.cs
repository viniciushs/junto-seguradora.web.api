namespace BackEnd.Domain.Models
{
    /// <summary>
    ///     Entidade Seguradora.
    /// </summary>
    public class Seguradora : BaseEntity
    {
        #region Construtores

        /// <summary>
        ///     Initializes a new instance of the <see cref="Seguradora"/> class.
        ///     Contrutor vazio utilizado pelo EntityFramework.
        /// </summary>
        public Seguradora()
            : base()
        {
        }

        #endregion Construtores

        #region Propriedades

        public string Cnpj { get; set; }

        public string Nome { get; set; }

        #endregion Propriedades
    }
}
