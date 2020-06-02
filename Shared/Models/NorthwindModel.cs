using System.ComponentModel.DataAnnotations;

namespace EFListView.Shared.Models
{
    public class Products
    {
        [Key]
        public int? ProductID { get; set; }

        public string ProductName { get; set; }
    }
}
