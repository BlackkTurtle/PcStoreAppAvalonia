using PcStore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcStore.DAL.Repositories.Contracts
{
    public interface IProductStoragesRepository : IGenericRepository<ProductStorage>
    {
        Task<bool> CheckAvaillabilityByProductId(int id);
    }
}
