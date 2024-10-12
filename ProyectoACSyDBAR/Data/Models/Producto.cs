using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ProyectoACSyDBAR.Data.Models
{
    public class Producto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
    }
}
