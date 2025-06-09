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
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly PcstoreContext _context;
        public ProductRepository(PcstoreContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<bool> CheckIfProductExistById(int id)
        {
            return await _context.Products.AnyAsync(p => p.Id == id);
        }

        public async Task<List<Product>> GetLastNProductsWith1Photo(int n)
        {
            return await _context.Products
                .OrderByDescending(p => p.Id)
                .Take(n)
                .Include(x => x.Photos.OrderBy(x => x.Id).Take(1))
                .Include(x => x.Comments)
                .ToListAsync();
        }

        public async Task<List<Product>> GetMultipleById(int[] ints)
        {
            var products = await _context.Products
                .Where(p => ints.Contains(p.Id))
                .Include(p => p.Photos.OrderBy(photo => photo.Id).Take(1))
                .Include(p => p.Comments)
                .ToListAsync();

            var productDict = products.ToDictionary(p => p.Id);
            return ints.Where(id => productDict.ContainsKey(id))
                       .Select(id => productDict[id])
                       .ToList();
        }
    }
}
