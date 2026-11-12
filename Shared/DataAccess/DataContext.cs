using Microsoft.EntityFrameworkCore;
using EFListView.Shared.Models;

namespace EFListView.Shared.DataAccess
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Locate the Shared/App_Data folder from the running output directory
                // (Server/bin/Debug/net10.0) so |DataDirectory| works from any clone location.
                var directory = new DirectoryInfo(AppContext.BaseDirectory);
                while (directory is not null && !Directory.Exists(Path.Combine(directory.FullName, "Shared", "App_Data")))
                {
                    directory = directory.Parent;
                }

                AppDomain.CurrentDomain.SetData("DataDirectory",
                    directory is null ? "App_Data" : Path.Combine(directory.FullName, "Shared", "App_Data"));

                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\NORTHWND.MDF';Integrated Security=True;Connect Timeout=30");
            }
        }
    }
}
