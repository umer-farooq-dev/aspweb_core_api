using Lecture1.Models;
using Microsoft.EntityFrameworkCore;

namespace Lecture1.Data
{
    public class ApplicatonDbContext : DbContext //Collection of Db set
    {
        public ApplicatonDbContext(DbContextOptions<ApplicatonDbContext> options)
            : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
