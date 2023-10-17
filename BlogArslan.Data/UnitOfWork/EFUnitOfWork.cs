using BlogArslan.Data.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogArslan.Data.UnitOfWork
{
    public class EFUnitOfWork : IdentityDbContext<User>
    {
    }
    public DbSet<BlogEntry> BlogEntries { get; set; } = null!;
}
