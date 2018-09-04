namespace Elra3y.DAL.Repositories.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        #region IUnitOfWork Members

        private CategoryRepository _categoryRepository;
        private ItemRepository _itemRepository;
        private PurchaseRepository _purchaseRepository;
        private SaleRepository _saleRepository;

        #endregion

        #region Repositries Properties

        public CategoryRepository CategoryRepository
            => _categoryRepository ?? (_categoryRepository = new CategoryRepository());

        public ItemRepository ItemRepository
            => _itemRepository ?? (_itemRepository = new ItemRepository());

        public PurchaseRepository PurchaseRepository
            => _purchaseRepository ?? (_purchaseRepository = new PurchaseRepository());

        public SaleRepository SaleRepository
            => _saleRepository ?? (_saleRepository = new SaleRepository());

        #endregion
    }
}