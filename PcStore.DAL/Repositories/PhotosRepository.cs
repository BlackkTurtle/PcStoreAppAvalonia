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
    public class PhotosRepository : GenericRepository<Photo>, IPhotosRepository
    {
        public PhotosRepository(PcstoreContext context)
            : base(context)
        {
        }
    }
}
