using product.Models;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Controlador responsável pelas operações relacionadas a produtos.
/// </summary>
[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    /// <summary>
    /// Cria uma nova instância do controlador de produtos.
    /// </summary>
    /// <param name="productService">Serviço responsável pela lógica de negócio relacionada a produtos.</param>
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    /// <summary>
    /// Adiciona um novo produto.
    /// </summary>
    /// <param name="product">Objeto contendo os dados do produto a ser adicionado.</param>
    [HttpPost]
    public void AddProduct([FromBody] Product product)
    {
        _productService.AddProduct(product);
    }

    /// <summary>
    /// Obtém a lista de todos os produtos cadastrados.
    /// </summary>
    /// <returns>Lista de produtos.</returns>
    [HttpGet]
    public List<Product> GetProducts()
    {
        return _productService.GetProducts();
    }

    /// <summary>
    /// Pesquisa um produto pelo ID.
    /// </summary>
    /// <param name="id">ID do produto a ser pesquisado.</param>
    /// <returns>O produto correspondente ao ID especificado, ou null se não encontrado.</returns>
    [HttpGet("{id}")]
    public Product? SearchProductId(Guid id)
    {
        return _productService.SearchProductId(id);
    }

    /// <summary>
    /// Atualiza os dados de um produto existente.
    /// </summary>
    /// <param name="id">ID do produto a ser atualizado.</param>
    /// <param name="product">Objeto contendo os novos dados do produto.</param>
    [HttpPut("{id}")]
    public void UpdateProduct(Guid id, [FromBody] Product product)
    {
        _productService.UpdateProduct(id, product);
    }

    /// <summary>
    /// Exclui um produto pelo ID.
    /// </summary>
    /// <param name="id">ID do produto a ser excluído.</param>
    [HttpDelete("{id}")]
    public void DeleteProduct(Guid id)
    {
        _productService.DeleteProduct(id);
    }
}
