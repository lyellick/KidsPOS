using KidsPOS.Common.Enums;

namespace KidsPOS.Common.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Categories Category { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public string Image { get; set; }

        public Guid ProductGuid { get; set; }

        public ICollection<ReceiptItem> ReceiptItems { get; set; }
    }
}
