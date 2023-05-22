using product.Models;

/// <summary>
/// Classe responsável por fornecer serviços relacionados aos produtos.
/// </summary>
public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    /// <summary>
    /// Construtor da classe ProductService.
    /// </summary>
    /// <param name="productRepository">Uma instância do repositório de produtos.</param>
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    /// <summary>
    /// Adiciona um novo produto.
    /// </summary>
    /// <param name="product">O produto a ser adicionado.</param>
    public void AddProduct(Product product)
    {
        _productRepository.AddProduct(product);
    }

    /// <summary>
    /// Obtém a lista de todos os produtos.
    /// </summary>
    /// <returns>A lista de produtos.</returns>
    public List<Product> GetProducts()
    {
        return _productRepository.GetProducts();
    }

    /// <summary>
    /// Procura um produto pelo ID.
    /// </summary>
    /// <param name="id">O ID do produto.</param>
    /// <returns>O produto correspondente ao ID especificado, ou null se não for encontrado.</returns>
    public Product? SearchProductId(Guid id)
    {
        return _productRepository.SearchProductId(id);
    }

    /// <summary>
    /// Atualiza as informações de um produto.
    /// </summary>
    /// <param name="id">O ID do produto a ser atualizado.</param>
    /// <param name="product">O objeto com as novas informações do produto.</param>
    public void UpdateProduct(Guid id, Product product)
    {
        _productRepository.UpdateProduct(product);
    }

    /// <summary>
    /// Exclui um produto.
    /// </summary>
    /// <param name="id">O ID do produto a ser excluído.</param>
    public void DeleteProduct(Guid id)
    {
        _productRepository.DeleteProduct(id);
    }
}
