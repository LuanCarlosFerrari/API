using client.Models;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Controlador responsável pelas operações relacionadas a clientes.
/// </summary>
[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
    private readonly IClientService _clientService;

    /// <summary>
    /// Cria uma nova instância do controlador de clientes.
    /// </summary>
    /// <param name="clientService">Serviço responsável pela lógica de negócio relacionada a clientes.</param>
    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }

    /// <summary>
    /// Adiciona um novo cliente.
    /// </summary>
    /// <param name="client">Objeto contendo os dados do cliente a ser adicionado.</param>
    [HttpPost]
    public void AddClient([FromBody] Client client)
    {
        _clientService.AddClient(client);
    }

    /// <summary>
    /// Obtém a lista de todos os clientes cadastrados.
    /// </summary>
    /// <returns>Lista de clientes.</returns>
    [HttpGet]
    public List<Client> GetClients()
    {
        return _clientService.GetClients();
    }

    /// <summary>
    /// Pesquisa um cliente pelo ID.
    /// </summary>
    /// <param name="id">ID do cliente a ser pesquisado.</param>
    /// <returns>O cliente correspondente ao ID especificado, ou null se não encontrado.</returns>
    [HttpGet("{id}")]
    public Client? SearchClientId(Guid id)
    {
        return _clientService.SearchClientId(id);
    }

    /// <summary>
    /// Atualiza os dados de um cliente existente.
    /// </summary>
    /// <param name="id">ID do cliente a ser atualizado.</param>
    /// <param name="client">Objeto contendo os novos dados do cliente.</param>
    [HttpPut("{id}")]
    public void UpdateClient(Guid id, [FromBody] Client client)
    {
        _clientService.UpdateClient(id, client);
    }

    /// <summary>
    /// Exclui um cliente pelo ID.
    /// </summary>
    /// <param name="id">ID do cliente a ser excluído.</param>
    [HttpDelete("{id}")]
    public void DeleteClient(Guid id)
    {
        _clientService.DeleteClient(id);
    }
}
