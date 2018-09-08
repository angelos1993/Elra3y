using Elra3y.BLL.Infrastructure;
using Elra3y.DAL.Model;

namespace Elra3y.BLL
{
    public class ItemManager : BaseManager
    {
        public void AddNewItem(Item item)
        {
            UnitOfWork.ItemRepository.Add(item);
        }

        public Item GetItemById(int itemId)
        {
            return UnitOfWork.ItemRepository.GetById(itemId);
        }

        public void UpdateItem(Item item)
        {
            UnitOfWork.ItemRepository.Update(item);
        }
    }
}