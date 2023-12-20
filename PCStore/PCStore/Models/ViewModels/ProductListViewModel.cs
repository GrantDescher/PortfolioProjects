using PCStore.Models.DomainModels;

namespace PCStore.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product>? Products { get; set; } = null;
        public IEnumerable<Category>? Categories { get; set; }
        public string? CurrentCategory { get; set; } = string.Empty;
    }
}
