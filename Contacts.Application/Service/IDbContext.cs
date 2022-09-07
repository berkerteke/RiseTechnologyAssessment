using Contacts.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Application.Service;

public interface IDbContext
{
    DbSet<Contact> Contacts { get; set; }
    DbSet<ContactDetail> ContactDetails { get; set; }
}