using KidsPOS.Common.Context;
using KidsPOS.Common.Models;
using KidsPOS.Common.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace KidsPOS.Common.Services
{
    public class KidsPOSService : IKidsPOSService
    {
        private readonly KidsPOSContext _context;

        public KidsPOSService(KidsPOSContext context) => _context = context;

        public async Task CreateReceipt(Product[] products)
        {
            List<ReceiptItem> items = new();

            Receipt receipt = new() { Created = DateTimeOffset.UtcNow, ReceiptGuid = Guid.NewGuid() };

            await _context.Receipts.AddAsync(receipt);
            await _context.SaveChangesAsync();
            
            items.AddRange(products.Select(product => new ReceiptItem() { ReceiptId = receipt.ReceiptId, ProductId = product.ProductId, Quantity = product.Quantity }));
            
            await _context.ReceiptItems.AddRangeAsync(items);
            await _context.SaveChangesAsync();

        }

        public async Task<Product[]> GetProducts() => await _context.Products.ToArrayAsync();
    }
}
