namespace XOakStore.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string CodigoBarras { get; set; }
        public int Estoque { get; set; }
    }
}
