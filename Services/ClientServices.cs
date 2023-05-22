using client.Models;

/// <summary>
/// Classe responsável por fornecer serviços relacionados aos clientes.
/// </summary>
public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;

    /// <summary>
    /// Construtor da classe ClientService.
    /// </summary>
    /// <param name="clientRepository">Uma instância do cliente de repositório de dados.</param>
    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    /// <summary>
    /// Adiciona um novo cliente.
    /// </summary>
    /// <param name="client">O cliente a ser adicionado.</param>
    public void AddClient(Client client)
    {
        _clientRepository.AddClient(client);
    }

    /// <summary>
    /// Obtém a lista de todos os clientes.
    /// </summary>
    /// <returns>A lista de clientes.</returns>
    public List<Client> GetClients()
    {
        return _clientRepository.GetClients();
    }

    /// <summary>
    /// Procura um cliente pelo ID.
    /// </summary>
    /// <param name="id">O ID do cliente.</param>
    /// <returns>O cliente correspondente ao ID especificado, ou null se não for encontrado.</returns>
    public Client? SearchClientId(Guid id)
    {
        return _clientRepository.SearchClientId(id);
    }

    /// <summary>
    /// Atualiza as informações de um cliente.
    /// </summary>
    /// <param name="id">O ID do cliente a ser atualizado.</param>
    /// <param name="client">O objeto com as novas informações do cliente.</param>
    public void UpdateClient(Guid id, Client client)
    {
        _clientRepository.UpdateClient(client);
    }

    /// <summary>
    /// Exclui um cliente.
    /// </summary>
    /// <param name="id">O ID do cliente a ser excluído.</param>
    public void DeleteClient(Guid id)
    {
        _clientRepository.DeleteClient(id);
    }
}
