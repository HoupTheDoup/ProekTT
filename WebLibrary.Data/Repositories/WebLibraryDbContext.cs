using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebLibrary.Data.Entities;

namespace WebLibrary.Data.Repositories
{
    public class WebLibraryDbContext : IdentityDbContext<UserEntity>
    {
        public WebLibraryDbContext(DbContextOptions<WebLibraryDbContext> options) 
            :base (options)  
        {

        }

        public DbSet<BookEntity> Books { get; set; }

        public DbSet<AuthorEntity> Authors { get; set; }

        public DbSet<PublisherEntity> Publishers { get; set; }
    }
}
