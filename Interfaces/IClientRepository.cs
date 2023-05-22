using client.Models;

public interface IClientRepository
{
    /// <summary>
    /// Adiciona um cliente.
    /// </summary>
    /// <param name="client">O objeto Client a ser adicionado.</param>
    void AddClient(Client client);

    /// <summary>
    /// Obtém todos os clientes.
    /// </summary>
    /// <returns>Uma lista de clientes.</returns>
    List<Client> GetClients();

    /// <summary>
    /// Procura um cliente pelo ID.
    /// </summary>
    /// <param name="id">O ID do cliente a ser procurado.</param>
    /// <returns>O objeto Client correspondente ao ID especificado, ou null se não for encontrado.</returns>
    Client? SearchClientId(Guid id);

    /// <summary>
    /// Atualiza as informações de um cliente.
    /// </summary>
    /// <param name="client">O objeto Client com as informações atualizadas.</param>
    void UpdateClient(Client client);

    /// <summary>
    /// Exclui um cliente pelo ID.
    /// </summary>
    /// <param name="id">O ID do cliente a ser excluído.</param>
    void DeleteClient(Guid id);
}
