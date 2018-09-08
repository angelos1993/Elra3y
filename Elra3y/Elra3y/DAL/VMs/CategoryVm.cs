using System.ComponentModel;

namespace Elra3y.DAL.VMs
{
    public class CategoryVm
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("الاسم")]
        public string Name { get; set; }
    }
}