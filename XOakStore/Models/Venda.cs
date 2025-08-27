namespace XOakStore.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal Total { get; set; }
        public string FormaPagamento { get; set; } // Pix, Dinheiro, Cartão
        public List<ItemVenda> ItensVenda { get; set; } // Lista de itens comprados
    }
}
