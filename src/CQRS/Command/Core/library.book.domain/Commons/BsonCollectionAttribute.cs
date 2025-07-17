namespace command.books.domain.Commons;
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class BsonCollectionAttribute : Attribute
{
  public string CollectionName;

  public BsonCollectionAttribute(string collectionName)
  {
    this.CollectionName = collectionName;
  }
}