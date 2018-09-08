using System;
using System.Linq;
using Elra3y.BLL;
using Elra3y.DAL.VMs;

namespace Elra3y.PL.Forms
{
    public partial class FrmCategories : FrmMaster
    {
        #region Constructor

        public FrmCategories()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private CategoryManager _categoryManager;

        private CategoryManager CategoryManager => _categoryManager ?? (_categoryManager = new CategoryManager());

        #endregion

        #region Events

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void LoadCategories()
        {
            dgvCategories.DataSource = CategoryManager.GetAllCategories().OrderBy(category => category.Name)
                .Select(category => new CategoryVm
                {
                    Id = category.Id,
                    Name = category.Name
                }).ToList();
        }

        #endregion
    }
}