using System.ComponentModel;

namespace Elra3y.DAL.VMs
{
    public class ItemVm
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("الفئة")]
        public string Category { get; set; }

        [DisplayName("الاسم")]
        public string Name { get; set; }

        [DisplayName("الكود")]
        public string Code { get; set; }
        
        [DisplayName("السعر جملة")]
        public decimal WholesalePrice { get; set; }

        [DisplayName("السعر بيع")]
        public decimal SellingPrice { get; set; }

        [DisplayName("الكمية")]
        public int Count { get; set; }
    }
}