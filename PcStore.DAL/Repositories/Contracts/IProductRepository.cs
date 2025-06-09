﻿using PcStore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcStore.DAL.Repositories.Contracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetLastNProductsWith1Photo(int n);
        Task<List<Product>> GetMultipleById(int[] ints);
        Task<bool> CheckIfProductExistById(int id);
    }
}
