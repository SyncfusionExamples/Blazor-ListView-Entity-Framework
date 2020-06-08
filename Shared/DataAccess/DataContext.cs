using Microsoft.EntityFrameworkCore;
using EFListView.Shared.Models;

namespace EFListView.Shared.DataAccess
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Shared.Models.Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Blazor-ListView-Entity-Framework\Shared\App_Data\NORTHWND.MDF;Integrated Security=True;Connect Timeout=30");
            }
        }
    }
}
