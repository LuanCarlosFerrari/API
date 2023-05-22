using product.Models;

public interface IProductRepository
{
    /// <summary>
    /// Adiciona um produto.
    /// </summary>
    /// <param name="product">O objeto Product a ser adicionado.</param>
    void AddProduct(Product product);

    /// <summary>
    /// Obtém todos os produtos.
    /// </summary>
    /// <returns>Uma lista de produtos.</returns>
    List<Product> GetProducts();

    /// <summary>
    /// Procura um produto pelo ID.
    /// </summary>
    /// <param name="id">O ID do produto a ser procurado.</param>
    /// <returns>O objeto Product correspondente ao ID especificado, ou null se não for encontrado.</returns>
    Product? SearchProductId(Guid id);

    /// <summary>
    /// Atualiza as informações de um produto.
    /// </summary>
    /// <param name="product">O objeto Product com as informações atualizadas.</param>
    void UpdateProduct(Product product);

    /// <summary>
    /// Exclui um produto pelo ID.
    /// </summary>
    /// <param name="id">O ID do produto a ser excluído.</param>
    void DeleteProduct(Guid id);
}
