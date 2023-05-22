using System.ComponentModel.DataAnnotations;

namespace client.Models
{
    /// <summary>
    /// Classe que representa um cliente.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Obtém ou define o ID do cliente.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Obtém ou define o nome do cliente.
        /// </summary>
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O comprimento do campo não pode exceder 50 caracteres.")]
        public string? Name { get; set; }
    }
}
