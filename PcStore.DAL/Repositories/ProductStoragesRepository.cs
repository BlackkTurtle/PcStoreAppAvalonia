using Microsoft.EntityFrameworkCore;
using PcStore.DAL.Models;
using PcStore.DAL.Persistence;
using PcStore.DAL.Repositories.Contracts;
using PCStore.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcStore.DAL.Repositories
{
    public class ProductStoragesRepository : GenericRepository<ProductStorage>, IProductStoragesRepository
    {
        private readonly PcstoreContext _context;
        public ProductStoragesRepository(PcstoreContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<bool> CheckAvaillabilityByProductId(int productId)
        {
            return await _context.ProductStorages.AnyAsync(p => p.ProductId == productId && p.Quantity > 0);
        }
    }
}
