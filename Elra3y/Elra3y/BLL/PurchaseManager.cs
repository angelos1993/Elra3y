using Elra3y.BLL.Infrastructure;
using Elra3y.DAL.Model;

namespace Elra3y.BLL
{
    public class PurchaseManager : BaseManager
    {
        public void AddNewPurchase(Purchase purchase)
        {
            UnitOfWork.PurchaseRepository.Add(purchase);
        }
    }
}