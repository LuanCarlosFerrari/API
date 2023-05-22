using System.ComponentModel.DataAnnotations;

namespace order.DTOs
{
    /// <summary>
    /// Classe OrderDTO.
    /// 
    /// Representa um objeto de transferência de dados (DTO) para a entidade Order.
    /// </summary>
    public class OrderDTO
    {
        /// <summary>
        /// Obtém ou define o ID do pedido.
        /// </summary>
        [Required(ErrorMessage = "Id is required.")]
        public Guid Id { get; set; }

        /// <summary>
        /// Obtém ou define a quantidade do pedido.
        /// </summary>
        [Required(ErrorMessage = "Amount is required.")]
        public float? Amount { get; set; }
        
        /// <summary>
        /// Obtém ou define a lista de produtos do pedido.
        /// </summary>
        public string? ProductList { get; set; }
    }
}
