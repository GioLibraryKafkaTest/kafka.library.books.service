using command.books.domain.Commons;
using library.core.domain.Events;

namespace command.books.domain.EventModels;
[BsonCollection("eventStore")]
public class EventModel : Document
{
  public DateTime TimeStamp { get; set; }
  public required string AggregateIdentifier { get; set; }
  public string AggregateType { get; set; }
  public int Version { get; set; }
  public string EventType { get; set; }
  public BaseEvent? EventData { get; set; }
}