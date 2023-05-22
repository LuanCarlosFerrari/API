using System.ComponentModel.DataAnnotations;

namespace product.DTOs
{
    /// <summary>
    /// Classe ProductDTO.
    /// 
    /// Representa um objeto de transferência de dados (DTO) para a entidade Product.
    /// </summary>
    public class ProductDTO
    {
        /// <summary>
        /// Obtém ou define o ID do produto.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Obtém ou define o nome do produto.
        /// </summary>
        [Required(ErrorMessage = "Product name is required.")]
        [MaxLength(50, ErrorMessage = "Field length cannot exceed 50 characters.")]
        public string? Name { get; set; }

        /// <summary>
        /// Obtém ou define o preço do produto.
        /// </summary>
        [Required(ErrorMessage = "Price is required.")]
        public float Price { get; set; }
    }
}
