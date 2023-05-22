using api.DBContext;
using product.Models;

/// <summary>
/// Classe responsável por interagir com a camada de persistência de dados para a entidade Product.
/// </summary>
public class ProductRepository : IProductRepository
{
    private readonly AppDBContext _dbContext;

    /// <summary>
    /// Construtor da classe ProductRepository.
    /// </summary>
    /// <param name="dbContext">Contexto do banco de dados.</param>
    public ProductRepository(AppDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Adiciona um novo produto ao contexto do banco de dados e salva as alterações.
    /// </summary>
    /// <param name="product">Objeto Product a ser adicionado.</param>
    public void AddProduct(Product product)
    {
        _dbContext.Products?.Add(product);
        _dbContext.SaveChanges();
    }

    /// <summary>
    /// Obtém uma lista de todos os produtos existentes no contexto do banco de dados.
    /// </summary>
    /// <returns>Lista de produtos.</returns>
    public List<Product> GetProducts()
    {
        if (_dbContext.Products != null)
        {
            return _dbContext.Products.ToList();
        }
        else
        {
            return new List<Product>();
        }
    }

    /// <summary>
    /// Procura um produto com base no ID especificado e retorna o primeiro produto encontrado.
    /// </summary>
    /// <param name="id">ID do produto a ser pesquisado.</param>
    /// <returns>Objeto Product correspondente ao ID especificado ou null se nenhum produto for encontrado.</returns>
    public Product? SearchProductId(Guid id)
    {
        if (_dbContext.Products != null)
        {
            return _dbContext.Products.FirstOrDefault(product => product.id == id);
        }
        else
        {
            return null;
        }
    }

    /// <summary>
    /// Atualiza as informações de um produto existente no contexto do banco de dados com base no ID especificado. Salva as alterações.
    /// </summary>
    /// <param name="product">Objeto Product com as novas informações.</param>
    public void UpdateProduct(Product product)
    {
        if (_dbContext.Products != null)
        {
            Product? productToUpdate = _dbContext.Products.FirstOrDefault(p => p.id == product.id);
            if (productToUpdate != null)
            {
                productToUpdate.name = product.name;
                productToUpdate.price = product.price;
                _dbContext.SaveChanges();
            }
        }
    }

    /// <summary>
    /// Remove um produto do contexto do banco de dados com base no ID especificado. Salva as alterações.
    /// </summary>
    /// <param name="id">ID do produto a ser removido.</param>
    public void DeleteProduct(Guid id)
    {
        if (_dbContext.Products != null)
        {
            Product? productToDelete = _dbContext.Products.FirstOrDefault(p => p.id == id);
            if (productToDelete != null)
            {
                _dbContext.Products.Remove(productToDelete);
                _dbContext.SaveChanges();
            }
        }
    }
}
