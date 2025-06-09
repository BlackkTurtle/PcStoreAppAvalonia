
using PcStore.DAL.Models;
using PcStore.DAL.Persistence;
using PcStore.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCStore.DAL.Repositories
{
    public class ContragentRepository:GenericRepository<Contragent>, IContragentRepository
    {
        public ContragentRepository(PcstoreContext context)
            : base(context)
        {
        }
    }
}
