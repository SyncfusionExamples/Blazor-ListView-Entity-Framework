using EFListView.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace EFListView.Shared.DataAccess
{
    public class DataAccessLayer
    {

        DataContext db = new DataContext();

        public DbSet<Products> GetAllProducts()
        {
            try
            {
                return db.Products;
            }
            catch
            {
                throw;
            }
        }

        public void AddProduct(Products products)
        {
            try
            {
                db.Products.Add(products);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteProduct(Products products)
        {
            try
            {
                db.Products.Remove(products);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
