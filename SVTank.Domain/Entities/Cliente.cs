namespace SVTank.Domain.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public int IdEndereco { get; set; }
    }
}
