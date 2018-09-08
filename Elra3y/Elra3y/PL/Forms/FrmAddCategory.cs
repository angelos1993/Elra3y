using System.Windows.Forms;
using Elra3y.BLL;
using Elra3y.DAL.Model;
using Elra3y.Utility;

namespace Elra3y.PL.Forms
{
    public partial class FrmAddCategory : FrmMaster
    {
        #region Constructor

        public FrmAddCategory(int? categoryId = null)
        {
            InitializeComponent();
            if (categoryId.HasValue)
                SetFormForEditMode(categoryId.Value);
        }

        #endregion

        #region Properties

        private CategoryManager _categoryManager;
        private CategoryManager CategoryManager => _categoryManager ?? (_categoryManager = new CategoryManager());
        private bool IsEditMode { get; set; }
        private Category Category { get; set; }

        #endregion

        #region Events

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveCategory();
            Close();
            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void SetFormForEditMode(int categoryId)
        {
            IsEditMode = true;
            Text = @"تعديل فئة";
            Category = CategoryManager.GetCategoryById(categoryId);
            txtName.Text = Category.Name;
        }

        private void SaveCategory()
        {
            ErrorProvider.Clear();
            if (txtName.Text.FullTrim().IsNullOrEmptyOrWhiteSpace())
            {
                ErrorProvider.SetError(txtName, Resources.RequiredValidation);
                return;
            }
            var category = new Category {Name = txtName.Text.FullTrim()};
            if (IsEditMode)
                CategoryManager.UpdateCategory(category);
            else
                CategoryManager.AddNewCategory(category);
        }

        #endregion
    }
}