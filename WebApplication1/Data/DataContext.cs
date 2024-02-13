using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<SuperHero> SuperHeroes { get; set; }

    }
    /* public async Task<ActionResult<SuperHero>> GetEmployee(int id, string name, string role)
     {
         var result = new object();
         var qry = new object();

         if (!string.IsNullOrEmpty(name))
         {
             result = await this.context.SuperHeroes.FindAsync(id);
         }
         if (!string.IsNullOrEmpty(email))
         {
             qry = qry.Where(u => u.email.Contains(email));
         }
         if (allPages)
             result.data = await qry.ToListAsync();
         else
             result.data = await qry.Skip(offset).Take(limit).ToListAsync();

         result.totalRows = await qry.CountAsync();


         return result;
     }*/
}
