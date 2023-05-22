namespace ClientDTO
{
    /// <summary>
    /// Classe ClientDTO.
    /// 
    /// Representa um objeto de transferência de dados (DTO) para a entidade Client.
    /// </summary>
    public class ClientDTO
    {
        /// <summary>
        /// Obtém ou define o ID do cliente.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Obtém ou define o nome do cliente.
        /// </summary>
        public string? Name { get; set; }
    }
}
