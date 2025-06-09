using PcStore.DAL.Models;
using PcStore.DAL.Persistence;
using PcStore.DAL.Repositories.Contracts;
using PCStore.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace PcStore.DAL.Repositories
{
    public class CharacteristicsRepository : GenericRepository<Characteristic>, ICharacteristicsRepository
    {
        public CharacteristicsRepository(PcstoreContext context)
            : base(context)
        {
        }
    }
}
