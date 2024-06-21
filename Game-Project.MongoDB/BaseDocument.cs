using Game_Project.Common;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Game_Project.MongoDB
{
    public abstract class BaseDocument : IEntity<ObjectId>
    {
        [BsonRepresentation(BsonType.ObjectId), BsonId]
        public ObjectId Id { get; set; }
    }
}
