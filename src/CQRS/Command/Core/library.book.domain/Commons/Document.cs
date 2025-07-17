﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace command.books.domain.Commons;
public class Document : IDocument
{
  [BsonId]
  [BsonRepresentation(BsonType.String)]
  public ObjectId Id { get; set; }
}