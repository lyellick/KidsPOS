namespace KidsPOS.Common.Models
{
    public class Receipt
    {
        public int ReceiptId { get; set; }

        public DateTimeOffset Created { get; set; }

        public Guid ReceiptGuid { get; set; }

        public virtual ICollection<ReceiptItem> ReceiptItems { get; set; }
    }
}
