using System.Collections.Generic;
using System.Linq;
using Elra3y.BLL.Infrastructure;
using Elra3y.DAL.Model;
using Elra3y.DAL.VMs;

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

        public List<Item> GetAllItemsKeyValuePairs()
        {
            return UnitOfWork.ItemRepository.GetAll().ToList();
        }

        public List<ItemVm> GetAllItemsVmsOrderedByName()
        {
            return UnitOfWork.ItemRepository.GetAll().OrderBy(item => item.Name).Select(item => new ItemVm
            {
                Id = item.Id,
                Category = item.Category.Name,
                Name = item.Name,
                Code = item.Code,
                WholesalePrice = item.WholesalePrice,
                SellingPrice = item.SellingPrice,
                Count = item.Count
            }).ToList();
        }

        public void UpdateItem(Item item)
        {
            UnitOfWork.ItemRepository.Update(item);
        }

        public void DecreaseItemCount(int itemId, int count)
        {
            var item = GetItemById(itemId);
            item.Count -= count;
            UpdateItem(item);
        }

        public IQueryable<Item> GetRequiredItemsQueryable()
        {
            return UnitOfWork.ItemRepository.Get(item => item.Count <= 1);
        }

        public List<RequiredItemVm> GetRequiredItems()
        {
            return GetRequiredItemsQueryable().OrderBy(item => item.Code).ThenBy(item => item.Name)
                .Select(item => new RequiredItemVm {ItemName = item.Name, CurrentCount = item.Count}).ToList();
        }

        public int GetRequiredItemsCount()
        {
            return GetRequiredItemsQueryable().Count();
        }

        public List<RequiredItemVm> SearchItemsByText(string text)
        {
            return UnitOfWork.ItemRepository.Get(item => item.Name.Contains(text))
                .Select(item => new RequiredItemVm {ItemName = item.Name, CurrentCount = item.Count}).ToList();
        }
    }
}