using System;
using System.Linq;
using System.Windows.Forms;
using Elra3y.BLL;
using Elra3y.DAL.Model;
using static Elra3y.Utility.MessageBoxUtility;

namespace Elra3y.PL.Forms
{
    public partial class FrmAddSale : FrmMaster
    {
        #region Constructor

        public FrmAddSale()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private CategoryManager _categoryManager;
        private CategoryManager CategoryManager => _categoryManager ?? (_categoryManager = new CategoryManager());
        private ItemManager _itemManager;
        private ItemManager ItemManager => _itemManager ?? (_itemManager = new ItemManager());
        private SaleManager _saleManager;
        private SaleManager SaleManager => _saleManager ?? (_saleManager=new SaleManager());

        #endregion

        #region Events

        private void FrmAddSale_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            dtSaleDate.Value = DateTime.Now;
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
            allCategories.Insert(0, new Category { Id = 0, Name = "الكل" });
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
            if (dblInPrice.Value <= 0)
            {
                ErrorProvider.SetError(dblInPrice, Resources.RequiredValidation);
                isFormValid = false;
            }
            if (!isFormValid)
                return;
            var selectedItemId = int.Parse(cmbItems.SelectedValue.ToString());
            var count = intInCount.Value;
            if (!SaleManager.IsItemAvailableToSale(selectedItemId, count))
            {
                ShowErrorMsg(Resources.SaleCountNotAvailable);
                return;
            }
            SaleManager.AddNewSale(new Sale
            {
                Date = dtSaleDate.Value,
                ItemId = selectedItemId,
                Count = count,
                Price = (decimal) dblInPrice.Value
            });
            ItemManager.DecreaseItemCount(selectedItemId, count);
            ShowInfoMsg(Resources.SaleAddedSuccessfully);
            Close();
        }

        #endregion
    }
}