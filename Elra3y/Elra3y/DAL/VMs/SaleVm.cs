using System;
using System.ComponentModel;

namespace Elra3y.DAL.VMs
{
    public class SaleVm
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("التاريخ")]
        public string Date { get; set; }

        [DisplayName("الصنف")]
        public string Item { get; set; }

        [DisplayName("الكمية")]
        public int Count { get; set; }

        [DisplayName("السعر")]
        public decimal Price { get; set; }
    }
}