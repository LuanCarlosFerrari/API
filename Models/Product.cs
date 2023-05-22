using System.ComponentModel.DataAnnotations;

namespace product.Models
{
    /// <summary>
    /// Classe que representa um produto.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Obtém ou define o ID do produto.
        /// </summary>
        public Guid id { get; set; }

        /// <summary>
        /// Obtém ou define o nome do produto.
        /// </summary>
        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo não pode ter mais de 50 caracteres.")]
        public string? name { get; set; }

        /// <summary>
        /// Obtém ou define o preço do produto.
        /// </summary>
        [Required(ErrorMessage = "O preço é obrigatório.")]
        public float? price { get; set; }
    }
}
