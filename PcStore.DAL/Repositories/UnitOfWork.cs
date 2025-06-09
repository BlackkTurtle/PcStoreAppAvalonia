using PcStore.DAL.Persistence;
using PcStore.DAL.Repositories;
using PcStore.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCStore.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PcstoreContext _dbContext;

        public UnitOfWork(PcstoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        private IAdvertisementRepository advertisementRepository;
        private IBrandRepository brandRepository;
        private ICategoryRepository categoryRepository;
        private ICharacteristicsRepository characteristicsRepository;
        private ICommentRepository commentRepository;
        private IContragentRepository contragentRepository;
        private IContragentDescriptionRepository contragentDescriptionRepository;
        private ICountManipulationRepository countManipulationRepository;
        private ICountOperationRepository countOperationRepository;
        private ICountRepository countRepository;
        private IDeliverAddressRepository deliverAddressRepository;
        private IDeliverOptionRepository deliverOptionRepository;
        private IInventarizationRepository inventarizationRepository;
        private IManipulationRepository manipulationRepository;
        private INakladniProductsRepository nakladniProductsRepository;
        private INakladniRepository nakladniRepository;
        private IOrderRepository orderRepository;
        private IPaymentRepository paymentRepository;
        private IPaymentTypeRepository paymentTypeRepository;
        private IPhotosRepository photosRepository;
        private IProductCharacteristicsRepository productCharacteristicsRepository;
        private IProductInventarizationRepository productInventarizationRepository;
        private IProductRepository productRepository;
        private IProductRestorageRepository productRestorageRepository;
        private IProductStoragesRepository productStoragesRepository;
        private IRestorageRepository restorageRepository;
        private IStorageRepository storageRepository;

        public IAdvertisementRepository AdvertisementRepository
        {
            get
            {
                if (advertisementRepository is null)
                {
                    advertisementRepository = new AdvertisementRepository(_dbContext);
                }

                return advertisementRepository;
            }
        }

        public IBrandRepository BrandRepository
        {
            get
            {
                if (brandRepository is null)
                {
                    brandRepository = new BrandRepository(_dbContext);
                }

                return brandRepository;
            }
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (categoryRepository is null)
                {
                    categoryRepository = new CategoryRepository(_dbContext);
                }
                return categoryRepository;
            }
        }

        public ICharacteristicsRepository CharacteristicsRepository
        {
            get
            {
                if (characteristicsRepository is null)
                {
                    characteristicsRepository = new CharacteristicsRepository(_dbContext);
                }
                return characteristicsRepository;
            }
        }

        public ICommentRepository CommentRepository
        {
            get
            {
                if (commentRepository is null)
                {
                    commentRepository = new CommentRepository(_dbContext);
                }
                return commentRepository;
            }
        }

        public IContragentRepository ContragentRepository
        {
            get
            {
                if (contragentRepository is null)
                {
                    contragentRepository = new ContragentRepository(_dbContext);
                }
                return contragentRepository;
            }
        }

        public IContragentDescriptionRepository ContragentDescriptionRepository
        {
            get
            {
                if (contragentDescriptionRepository is null)
                {
                    contragentDescriptionRepository = new ContragentDescriptionRepository(_dbContext);
                }
                return contragentDescriptionRepository;
            }
        }

        public ICountManipulationRepository CountManipulationRepository
        {
            get
            {
                if (countManipulationRepository is null)
                {
                    countManipulationRepository = new CountManipulationRepository(_dbContext);
                }
                return countManipulationRepository;
            }
        }

        public ICountOperationRepository CountOperationRepository
        {
            get
            {
                if (countOperationRepository is null)
                {
                    countOperationRepository = new CountOperationRepository(_dbContext);
                }
                return countOperationRepository;
            }
        }

        public ICountRepository CountRepository
        {
            get
            {
                if (countRepository is null)
                {
                    countRepository = new CountRepository(_dbContext);
                }
                return countRepository;
            }
        }

        public IDeliverAddressRepository DeliverAddressRepository
        {
            get
            {
                if (deliverAddressRepository is null)
                {
                    deliverAddressRepository = new DeliverAddressRepository(_dbContext);
                }
                return deliverAddressRepository;
            }
        }

        public IDeliverOptionRepository DeliverOptionRepository
        {
            get
            {
                if (deliverOptionRepository is null)
                {
                    deliverOptionRepository = new DeliverOptionRepository(_dbContext);
                }
                return deliverOptionRepository;
            }
        }

        public IInventarizationRepository InventarizationRepository
        {
            get
            {
                if (inventarizationRepository is null)
                {
                    inventarizationRepository = new InventarizationRepository(_dbContext);
                }
                return inventarizationRepository;
            }
        }

        public IManipulationRepository ManipulationRepository
        {
            get
            {
                if (manipulationRepository is null)
                {
                    manipulationRepository = new ManipulationRepository(_dbContext);
                }
                return manipulationRepository;
            }
        }

        public INakladniProductsRepository NakladniProductsRepository
        {
            get
            {
                if (nakladniProductsRepository is null)
                {
                    nakladniProductsRepository = new NakladniProductsRepository(_dbContext);
                }
                return nakladniProductsRepository;
            }
        }

        public INakladniRepository NakladniRepository
        {
            get
            {
                if (nakladniRepository is null)
                {
                    nakladniRepository = new NakladniRepository(_dbContext);
                }
                return nakladniRepository;
            }
        }

        public IOrderRepository OrderRepository
        {
            get
            {
                if (orderRepository is null)
                {
                    orderRepository = new OrderRepository(_dbContext);
                }
                return orderRepository;
            }
        }

        public IPaymentRepository PaymentRepository
        {
            get
            {
                if (paymentRepository is null)
                {
                    paymentRepository = new PaymentRepository(_dbContext);
                }
                return paymentRepository;
            }
        }

        public IPaymentTypeRepository PaymentTypeRepository
        {
            get
            {
                if (paymentTypeRepository is null)
                {
                    paymentTypeRepository = new PaymentTypeRepository(_dbContext);
                }
                return paymentTypeRepository;
            }
        }

        public IPhotosRepository PhotosRepository
        {
            get
            {
                if (photosRepository is null)
                {
                    photosRepository = new PhotosRepository(_dbContext);
                }
                return photosRepository;
            }
        }

        public IProductCharacteristicsRepository ProductCharacteristicsRepository
        {
            get
            {
                if (productCharacteristicsRepository is null)
                {
                    productCharacteristicsRepository = new ProductCharacteristicsRepository(_dbContext);
                }
                return productCharacteristicsRepository;
            }
        }

        public IProductInventarizationRepository ProductInventarizationRepository
        {
            get
            {
                if (productInventarizationRepository is null)
                {
                    productInventarizationRepository = new ProductInventarizationRepository(_dbContext);
                }
                return productInventarizationRepository;
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (productRepository is null)
                {
                    productRepository = new ProductRepository(_dbContext);
                }
                return productRepository;
            }
        }

        public IProductRestorageRepository ProductRestorageRepository
        {
            get
            {
                if (productRestorageRepository is null)
                {
                    productRestorageRepository = new ProductRestorageRepository(_dbContext);
                }
                return productRestorageRepository;
            }
        }

        public IProductStoragesRepository ProductStoragesRepository
        {
            get
            {
                if (productStoragesRepository is null)
                {
                    productStoragesRepository = new ProductStoragesRepository(_dbContext);
                }
                return productStoragesRepository;
            }
        }

        public IRestorageRepository RestorageRepository
        {
            get
            {
                if (restorageRepository is null)
                {
                    restorageRepository = new RestorageRepository(_dbContext);
                }
                return restorageRepository;
            }
        }

        public IStorageRepository StorageRepository
        {
            get
            {
                if (storageRepository is null)
                {
                    storageRepository = new StorageRepository(_dbContext);
                }
                return storageRepository;
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
