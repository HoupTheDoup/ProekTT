using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebLibrary.Data.Entities;

namespace WebLibrary.Data.Repositories
{
    public class WebLibraryContext : IdentityDbContext<UserEntity>
    {
        public WebLibraryContext(DbContextOptions<WebLibraryContext> options) 
            :base (options)  
        {

        }

        public DbSet<BookEntity> BookEntities { get; set; }

        public DbSet<AuthorEntity> AuthorEntities { get; set; }
    }
}
