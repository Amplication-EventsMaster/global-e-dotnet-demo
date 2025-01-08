using Microsoft.EntityFrameworkCore;

namespace Service_2.Infrastructure;

public class Service_2DbContext : DbContext
{
    public Service_2DbContext(DbContextOptions<Service_2DbContext> options)
        : base(options) { }
}
