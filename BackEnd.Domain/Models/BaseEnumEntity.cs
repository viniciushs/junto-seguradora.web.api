namespace BackEnd.Domain.Models
{
    public abstract class BaseEnumEntity : BaseEntity
    {
        public BaseEnumEntity()
            : base()
        {
        }

        public BaseEnumEntity(int id, string descricao)
            : base()
        {
            this.Id = id;
            this.Descricao = descricao;
        }

        public string Descricao { get; set; }
    }
}
