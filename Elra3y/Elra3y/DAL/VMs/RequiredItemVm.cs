using System.ComponentModel;

namespace Elra3y.DAL.VMs
{
    public class RequiredItemVm
    {
        [DisplayName("اسم الصنف")]
        public string ItemName { get; set; }

        [DisplayName("الكمية المتاحة الآن")]
        public int CurrentCount { get; set; }
    }
}