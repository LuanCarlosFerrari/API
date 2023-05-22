using order.Models;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Controlador responsável pelas operações relacionadas a pedidos.
/// </summary>
[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    /// <summary>
    /// Cria uma nova instância do controlador de pedidos.
    /// </summary>
    /// <param name="orderService">Serviço responsável pela lógica de negócio relacionada a pedidos.</param>
    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    /// <summary>
    /// Adiciona um novo pedido.
    /// </summary>
    /// <param name="order">Objeto contendo os dados do pedido a ser adicionado.</param>
    [HttpPost]
    public void AddOrder([FromBody] Order order)
    {
        _orderService.AddOrder(order);
    }

    /// <summary>
    /// Obtém a lista de todos os pedidos cadastrados.
    /// </summary>
    /// <returns>Lista de pedidos.</returns>
    [HttpGet]
    public List<Order> GetOrders()
    {
        return _orderService.GetOrders();
    }

    /// <summary>
    /// Pesquisa um pedido pelo ID.
    /// </summary>
    /// <param name="id">ID do pedido a ser pesquisado.</param>
    /// <returns>O pedido correspondente ao ID especificado, ou null se não encontrado.</returns>
    [HttpGet("{id}")]
    public Order? SearchOrderId(Guid id)
    {
        return _orderService.SearchOrderId(id);
    }

    /// <summary>
    /// Atualiza os dados de um pedido existente.
    /// </summary>
    /// <param name="id">ID do pedido a ser atualizado.</param>
    /// <param name="order">Objeto contendo os novos dados do pedido.</param>
    [HttpPut("{id}")]
    public void UpdateOrder(Guid id, [FromBody] Order order)
    {
        _orderService.UpdateOrder(id, order);
    }

    /// <summary>
    /// Exclui um pedido pelo ID.
    /// </summary>
    /// <param name="id">ID do pedido a ser excluído.</param>
    [HttpDelete("{id}")]
    public void DeleteOrder(Guid id)
    {
        _orderService.DeleteOrder(id);
    }
}
