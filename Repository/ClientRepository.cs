using api.DBContext;
using client.Models;

/// <summary>
/// Classe responsável por interagir com a camada de persistência de dados para a entidade Client.
/// </summary>
public class ClientRepository : IClientRepository
{
    private readonly AppDBContext _dbContext;

    /// <summary>
    /// Construtor da classe ClientRepository.
    /// /// </summary>
    /// <param name="dbContext">Contexto do banco de dados.</param>
    public ClientRepository(AppDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Adiciona um novo cliente ao contexto do banco de dados e salva as alterações.
    /// </summary>
    /// <param name="client">Objeto Client a ser adicionado.</param>
    public void AddClient(Client client)
    {
        client.Id = Guid.NewGuid();
        _dbContext.Clients?.Add(client);
        _dbContext.SaveChanges();
    }

    /// <summary>
    /// Obtém uma lista de todos os clientes existentes no contexto do banco de dados.
    /// </summary>
    /// <returns>Lista de clientes.</returns>
    public List<Client> GetClients()
    {
        if (_dbContext.Clients != null)
        {
            return _dbContext.Clients.ToList();
        }
        else
        {
            return new List<Client>();
        }
    }

    /// <summary>
    /// Procura um cliente com base no ID especificado e retorna o primeiro cliente encontrado.
    /// </summary>
    /// <param name="id">ID do cliente a ser pesquisado.</param>
    /// <returns>Objeto Client correspondente ao ID especificado ou null se nenhum cliente for encontrado.</returns>
    public Client? SearchClientId(Guid id)
    {
        if (_dbContext.Clients != null)
        {
            return _dbContext.Clients.FirstOrDefault(client => client.Id == id);
        }
        else
        {
            return null;
        }
    }

    /// <summary>
    /// Atualiza as informações de um cliente existente no contexto do banco de dados com base no ID especificado. Salva as alterações.
    /// </summary>
    /// <param name="client">Objeto Client com as novas informações.</param>
    public void UpdateClient(Client client)
    {
        if (_dbContext.Clients != null)
        {
            Client? clientToUpdate = _dbContext.Clients.FirstOrDefault(c => c.Id == client.Id);
            if (clientToUpdate != null)
            {
                clientToUpdate.Name = client.Name;
                _dbContext.SaveChanges();
            }
        }
    }

    /// <summary>
    /// Remove um cliente do contexto do banco de dados com base no ID especificado. Salva as alterações.
    /// </summary>
    /// <param name="id">ID do cliente a ser removido.</param>
    public void DeleteClient(Guid id)
    {
        if (_dbContext.Clients != null)
        {
            Client? clientToDelete = _dbContext.Clients.FirstOrDefault(c => c.Id == id);
            if (clientToDelete != null)
            {
                _dbContext.Clients.Remove(clientToDelete);
                _dbContext.SaveChanges();
            }
        }
    }
}
