using System.ComponentModel.DataAnnotations;

namespace order.Models
{
    /// <summary>
    /// Classe que representa um pedido.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Obtém ou define o ID do pedido.
        /// </summary>
        [Required(ErrorMessage = "O ID é obrigatório.")]
        public Guid Id { get; set; }

        /// <summary>
        /// Obtém ou define o valor do pedido.
        /// </summary>
        [Required(ErrorMessage = "O valor é obrigatório.")]
        public float? Amount { get; set; }

        /// <summary>
        /// Obtém ou define a lista de produtos do pedido.
        /// </summary>
        public string? ProductList { get; set; }
    }
}
