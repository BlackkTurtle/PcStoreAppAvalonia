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
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        private readonly PcstoreContext _context;
        public CommentRepository(PcstoreContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<bool> CheckIfCommentWithProductIdExist(int productId, int id)
        {
            return await _context.Comments.AnyAsync(x => x.Id == id && x.ProductId == productId && x.ParentId == null && x.IsReview == false);
        }

        public async Task<double> GetRatingByProductId(int productId)
        {
            return await _context.Comments
                .Where(c => c.ProductId == productId)
                .AverageAsync(c => (double?)c.Rating) ?? 0.0;
        }
    }
}
