using System;
using System.Windows.Forms;
using Elra3y.BLL;
using Elra3y.DAL.Model;
using Elra3y.Utility;
using static Elra3y.Utility.MessageBoxUtility;

namespace Elra3y.PL.Forms
{
    public partial class FrmAddItem : FrmMaster
    {
        #region Constructor

        public FrmAddItem(int? itemId = null)
        {
            InitializeComponent();
            if (itemId.HasValue)
                SetFormForEditMode(itemId.Value);
        }

        #endregion

        #region Properties

        private CategoryManager _categoryManager;
        private CategoryManager CategoryManager => _categoryManager ?? (_categoryManager = new CategoryManager());
        private ItemManager _itemManager;
        private ItemManager ItemManager => _itemManager ?? (_itemManager = new ItemManager());
        private bool IsEditMode { get; set; }
        private Item Item { get; set; }

        #endregion

        #region Events

        private void FrmAddItem_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadCategories();
            Cursor = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveItem();
            Close();
            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void LoadCategories()
        {
            var allCategories = CategoryManager.GetAllCategories();
            allCategories.Insert(0, new Category {Id = 0, Name = "إختر الفئة"});
            cmbCaterories.DataSource = allCategories;
            cmbCaterories.ValueMember = "Id";
            cmbCaterories.DisplayMember = "Name";
        }

        private void SetFormForEditMode(int itemId)
        {
            IsEditMode = true;
            Text = @"تعديل صنف";
            Item = ItemManager.GetItemById(itemId);
            cmbCaterories.SelectedValue = Item.CategoryId;
            txtName.Text = Item.Name;
            txtShortName.Text = Item.ShortName;
            txtCode.Text = Item.Code;
            dblInWholesalePrice.Value = (double) Item.WholesalePrice;
            dblInSellingPrice.Value = (double) Item.SellingPrice;
            intInCount.Value = Item.Count;
        }

        private void SaveItem()
        {
            ErrorProvider.Clear();
            var isFormValid = true;
            if (cmbCaterories.SelectedIndex == 0)
            {
                ErrorProvider.SetError(cmbCaterories, Resources.RequiredValidation);
                isFormValid = false;
            }
            if (txtName.Text.FullTrim().IsNullOrEmptyOrWhiteSpace())
            {
                ErrorProvider.SetError(txtName, Resources.RequiredValidation);
                isFormValid = false;
            }
            if (txtShortName.Text.FullTrim().IsNullOrEmptyOrWhiteSpace())
            {
                ErrorProvider.SetError(txtShortName, Resources.RequiredValidation);
                isFormValid = false;
            }
            if (txtCode.Text.FullTrim().IsNullOrEmptyOrWhiteSpace())
            {
                ErrorProvider.SetError(txtCode, Resources.RequiredValidation);
                isFormValid = false;
            }
            if (Math.Abs(dblInWholesalePrice.Value) <= 0)
            {
                ErrorProvider.SetError(dblInWholesalePrice, Resources.RequiredValidation);
                isFormValid = false;
            }
            if (Math.Abs(dblInSellingPrice.Value) <= 0)
            {
                ErrorProvider.SetError(dblInSellingPrice, Resources.RequiredValidation);
                isFormValid = false;
            }
            if (intInCount.Value == 0)
            {
                ErrorProvider.SetError(intInCount, Resources.RequiredValidation);
                isFormValid = false;
            }
            if (!isFormValid)
                return;
            var item = new Item
            {
                Name = txtName.Text.FullTrim(),
                ShortName = txtShortName.Text.FullTrim(),
                Code = txtCode.Text.FullTrim(),
                WholesalePrice = (decimal) dblInWholesalePrice.Value,
                SellingPrice = (decimal) dblInSellingPrice.Value,
                Count = intInCount.Value,
                CategoryId = int.Parse(cmbCaterories.SelectedValue.ToString())
            };
            if (IsEditMode)
            {
                ItemManager.UpdateItem(item);
                ShowInfoMsg(Resources.ItemUpdatedSuccessfully);
            }
            else
            {
                ItemManager.AddNewItem(item);
                ShowInfoMsg(Resources.ItemAddedSuccessfully);
            }
        }

        #endregion
    }
}