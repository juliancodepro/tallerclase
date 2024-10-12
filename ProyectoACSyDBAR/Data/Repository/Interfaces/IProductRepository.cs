using ProyectoACSyDBAR.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ProyectoACSyDBAR.Data.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Producto>> GetAllProductosAsync();
        Task<Producto> GetProductoByIdAsync(String Id);
        Task CreateProductoAsync(Producto producto);
        Task <bool> UpdateProductoAsync(string id, Producto producto);
        Task <bool> DeleteProductoAsync(string id);
    }
}
