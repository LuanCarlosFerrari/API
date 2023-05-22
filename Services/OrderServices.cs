using order.Models;

/// <summary>
/// Classe responsável por fornecer serviços relacionados aos pedidos.
/// </summary>
public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    /// <summary>
    /// Construtor da classe OrderService.
    /// </summary>
    /// <param name="orderRepository">Uma instância do repositório de pedidos.</param>
    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    /// <summary>
    /// Adiciona um novo pedido.
    /// </summary>
    /// <param name="order">O pedido a ser adicionado.</param>
    public void AddOrder(Order order)
    {
        _orderRepository.AddOrder(order);
    }

    /// <summary>
    /// Obtém a lista de todos os pedidos.
    /// </summary>
    /// <returns>A lista de pedidos.</returns>
    public List<Order> GetOrders()
    {
        return _orderRepository.GetOrders();
    }

    /// <summary>
    /// Procura um pedido pelo ID.
    /// </summary>
    /// <param name="id">O ID do pedido.</param>
    /// <returns>O pedido correspondente ao ID especificado, ou null se não for encontrado.</returns>
    public Order? SearchOrderId(Guid id)
    {
        return _orderRepository.SearchOrderId(id);
    }

    /// <summary>
    /// Atualiza as informações de um pedido.
    /// </summary>
    /// <param name="id">O ID do pedido a ser atualizado.</param>
    /// <param name="order">O objeto com as novas informações do pedido.</param>
    public void UpdateOrder(Guid id, Order order)
    {
        _orderRepository.UpdateOrder(order);
    }

    /// <summary>
    /// Exclui um pedido.
    /// </summary>
    /// <param name="id">O ID do pedido a ser excluído.</param>
    public void DeleteOrder(Guid id)
    {
        _orderRepository.DeleteOrder(id);
    }
}
