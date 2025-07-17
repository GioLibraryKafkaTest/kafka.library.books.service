using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace command.books.domain.Commons;
public interface IDocument
{
  [BsonId]
  [BsonRepresentation(BsonType.String)]
  ObjectId Id { get; set; }
}