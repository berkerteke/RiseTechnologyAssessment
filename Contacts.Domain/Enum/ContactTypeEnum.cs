using System.ComponentModel;

namespace Contacts.Domain.Enum;

public enum ContactTypeEnum
{
    [Description("Gsm Number")]
    GsmNumber,
    [Description("Email Address")]
    EmailAddress,
    [Description("Location")]
    Location
}