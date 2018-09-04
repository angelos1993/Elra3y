namespace Elra3y.DAL.Repositories.Infrastructure
{
    public interface IUnitOfWork
    {
        CategoryRepository CategoryRepository { get; }
        ItemRepository ItemRepository { get; }
        PurchaseRepository PurchaseRepository { get; }
        SaleRepository SaleRepository { get; }
    }
}