using api.DBContext;
using order.Models;

/// <summary>
/// Classe responsável por interagir com a camada de persistência de dados para a entidade Order.
/// </summary>
public class OrderRepository : IOrderRepository
{
    private readonly AppDBContext _dbContext;

    /// <summary>
    /// Construtor da classe OrderRepository.
    /// </summary>
    /// <param name="dbContext">Contexto do banco de dados.</param>
    public OrderRepository(AppDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Adiciona um novo pedido ao contexto do banco de dados e salva as alterações.
    /// </summary>
    /// <param name="order">Objeto Order a ser adicionado.</param>
    public void AddOrder(Order order)
    {
        _dbContext.Orders?.Add(order);
        _dbContext.SaveChanges();
    }

    /// <summary>
    /// Obtém uma lista de todos os pedidos existentes no contexto do banco de dados.
    /// </summary>
    /// <returns>Lista de pedidos.</returns>
    public List<Order> GetOrders()
    {
        if (_dbContext.Orders != null)
        {
            return _dbContext.Orders.ToList();
        }
        else
        {
            return new List<Order>();
        }
    }

    /// <summary>
    /// Procura um pedido com base no ID especificado e retorna o primeiro pedido encontrado.
    /// </summary>
    /// <param name="id">ID do pedido a ser pesquisado.</param>
    /// <returns>Objeto Order correspondente ao ID especificado ou null se nenhum pedido for encontrado.</returns>
    public Order? SearchOrderId(Guid id)
    {
        if (_dbContext.Orders != null)
        {
            return _dbContext.Orders.FirstOrDefault(order => order.Id == id);
        }
        else
        {
            return null;
        }
    }

    /// <summary>
    /// Atualiza as informações de um pedido existente no contexto do banco de dados com base no ID especificado. Salva as alterações.
    /// </summary>
    /// <param name="order">Objeto Order com as novas informações.</param>
    public void UpdateOrder(Order order)
    {
        if (_dbContext.Orders != null)
        {
            Order? orderToUpdate = _dbContext.Orders.FirstOrDefault(o => o.Id == order.Id);
            if (orderToUpdate != null)
            {
                orderToUpdate.Amount = order.Amount;
                orderToUpdate.ProductList = order.ProductList;
                _dbContext.SaveChanges();
            }
        }
    }

    /// <summary>
    /// Remove um pedido do contexto do banco de dados com base no ID especificado. Salva as alterações.
    /// </summary>
    /// <param name="id">ID do pedido a ser removido.</param>
    public void DeleteOrder(Guid id)
    {
        if (_dbContext.Orders != null)
        {
            Order? orderToDelete = _dbContext.Orders.FirstOrDefault(o => o.Id == id);
            if (orderToDelete != null)
            {
                _dbContext.Orders.Remove(orderToDelete);
                _dbContext.SaveChanges();
            }
        }
    }
}
