using Contacts.Domain.Enum;

namespace Contacts.Domain.Entity;

public class ContactDetail
{
    public ContactTypeEnum ContactType { get; set; }
    public string Content { get; set; }
    public Guid ContactId { get; set; }
    public virtual Contact Contact { get; set; }
}