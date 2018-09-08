using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using Elra3y.BLL.Infrastructure;
using Elra3y.DAL.Model;
using Elra3y.DAL.VMs;

namespace Elra3y.BLL
{
    public class SaleManager : BaseManager
    {
        public void AddNewSale(Sale sale)
        {
            UnitOfWork.SaleRepository.Add(sale);
        }

        public bool IsItemAvailableToSale(int itemId, int count)
        {
            var itemAvailableCount = UnitOfWork.ItemRepository.Get(item => item.Id == itemId).Select(item => item.Count)
                .FirstOrDefault();
            return itemAvailableCount >= count;
        }

        public List<SaleVm> GetSalesByDate(DateTime dateTime)
        {
            return UnitOfWork.SaleRepository.Get(sale => SqlFunctions.DateDiff("DAY", dateTime, sale.Date) == 0)
                .ToList().Select(sale => new SaleVm
                {
                    Id = sale.Id,
                    Date = sale.Date.ToShortDateString(),
                    Item = sale.Item.Name,
                    Count = sale.Count,
                    Price = sale.Price
                }).ToList();
        }
    }
}