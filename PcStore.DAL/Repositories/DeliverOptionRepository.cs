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
    public class DeliverOptionRepository : GenericRepository<DeliverOption>, IDeliverOptionRepository
    {
        public DeliverOptionRepository(PcstoreContext context)
            : base(context)
        {
        }
    }
}
