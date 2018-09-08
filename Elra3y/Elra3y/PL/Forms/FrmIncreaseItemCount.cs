using System;
using System.Linq;
using System.Windows.Forms;
using Elra3y.BLL;
using Elra3y.DAL.Model;
using static Elra3y.Utility.MessageBoxUtility;

namespace Elra3y.PL.Forms
{
    public partial class FrmIncreaseItemCount : FrmMaster
    {
        #region Constructor

        public FrmIncreaseItemCount()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private CategoryManager _categoryManager;
        private CategoryManager CategoryManager => _categoryManager ?? (_categoryManager = new CategoryManager());
        private ItemManager _itemManager;
        private ItemManager ItemManager => _itemManager ?? (_itemManager = new ItemManager());

        #endregion

        #region Events

        private void FrmIncreaseItemCount_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FillComboBoxes();
            Cursor = Cursors.Default;
        }

        private void cmbCaterories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var selectedCategoryId = int.Parse(cmbCaterories.SelectedValue.ToString());
            var allItems = ItemManager.GetAllItemsKeyValuePairs();
            allItems = allItems.Where(item => selectedCategoryId == 0 || item.CategoryId == selectedCategoryId)
                .ToList();
            cmbItems.DataSource = allItems;
            cmbItems.ValueMember = "Id";
            cmbItems.DisplayMember = "Name";
            Cursor = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Save();
            Close();
            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void FillComboBoxes()
        {
            var allCategories = CategoryManager.GetAllCategories();
            allCategories.Insert(0, new Category {Id = 0, Name = "الكل"});
            cmbCaterories.DataSource = allCategories;
            cmbCaterories.ValueMember = "Id";
            cmbCaterories.DisplayMember = "Name";
        }

        private void Save()
        {
            ErrorProvider.Clear();
            var isFormValid = true;
            if (cmbItems.SelectedIndex <= 0)
            {
                ErrorProvider.SetError(cmbItems, Resources.RequiredValidation);
                isFormValid = false;
            }
            if (intInCount.Value <= 0)
            {
                ErrorProvider.SetError(intInCount, Resources.RequiredValidation);
                isFormValid = false;
            }
            if (!isFormValid)
                return;
            var item = ItemManager.GetItemById(int.Parse(cmbItems.SelectedValue.ToString()));
            item.Count += intInCount.Value;
            ItemManager.UpdateItem(item);
            ShowInfoMsg(Resources.ItemCountAddesSuccessfully);
        }

        #endregion
    }
}