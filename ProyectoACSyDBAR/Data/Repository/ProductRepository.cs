using MongoDB.Driver;
using ProyectoACSyDBAR.Data.Models;
using ProyectoACSyDBAR.Data.Repository.Interfaces;

namespace ProyectoACSyDBAR.Data.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly IMongoCollection<Producto> _productos;

        public ProductRepository(IMongoClient client)
        {

            var baseDeDatos = client.GetDatabase("CarniceriaDb");
            _productos = baseDeDatos.GetCollection<Producto>("ColeccionDeProductos");
        }

        // Crear un producto
        public async Task CreateProductAsync(Producto producto) 
        {
        
            await _productos.InsertOneAsync(producto);

        }
        // Obtener todos los productos
        public async Task<IEnumerable<Producto>> GetAllProductosAsync()
        {

            return await _productos.Find(Producto => true).ToListAsync();

        }

        // Obtener un producto por ID
        public async Task<Producto> GetProductoByIdAsync(string id)
        {
            return await _productos.Find(producto => producto.Id == id).FirstOrDefaultAsync();
        }

        // Actualizar un producto
        public async Task <bool> UpdateProductoAsync(string id, Producto producto)
        {
            var result = await _productos.ReplaceOneAsync(p => p.Id == id, producto);
            return result.IsAcknowledged && result.ModifiedCount == 0;
        }

        // Eliminar un producto
        public async Task <bool> DeleteProductAsync(string id)
        {
            var result = await _productos.DeleteOneAsync(p => p.Id == id);
            return result.IsAcknowledged && result.DeletedCount > 0;   
        }

        Task IProductRepository.CreateProductoAsync(Producto producto)
        {
            throw new NotImplementedException();
        }

        Task<bool> IProductRepository.DeleteProductoAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
    }

