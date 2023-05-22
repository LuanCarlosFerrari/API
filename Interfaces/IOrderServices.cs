using order.Models;

public interface IOrderService
{
    /// <summary>
    /// Adiciona um pedido.
    /// </summary>
    /// <param name="order">O objeto Order a ser adicionado.</param>
    void AddOrder(Order order);

    /// <summary>
    /// Obtém todos os pedidos.
    /// </summary>
    /// <returns>Uma lista de pedidos.</returns>
    List<Order> GetOrders();

    /// <summary>
    /// Procura um pedido pelo ID.
    /// </summary>
    /// <param name="id">O ID do pedido a ser procurado.</param>
    /// <returns>O objeto Order correspondente ao ID especificado, ou null se não for encontrado.</returns>
    Order? SearchOrderId(Guid id);

    /// <summary>
    /// Atualiza as informações de um pedido.
    /// </summary>
    /// <param name="id">O ID do pedido a ser atualizado.</param>
    /// <param name="order">O objeto Order com as informações atualizadas.</param>
    void UpdateOrder(Guid id, Order order);

    /// <summary>
    /// Exclui um pedido pelo ID.
    /// </summary>
    /// <param name="id">O ID do pedido a ser excluído.</param>
    void DeleteOrder(Guid id);
}
