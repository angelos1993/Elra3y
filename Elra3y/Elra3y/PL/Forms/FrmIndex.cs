using System;
using DevComponents.DotNetBar;
using Elra3y.BLL;
using Elra3y.Utility;

namespace Elra3y.PL.Forms
{
    public partial class FrmIndex : Office2007Form
    {
        #region Constructor

        public FrmIndex()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private ItemManager _itemManager;
        private ItemManager ItemManager => _itemManager ?? (_itemManager = new ItemManager());

        #endregion

        #region Events

        #region Sales

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            new FrmAddSale().ShowDialog();
        }

        private void btnListSales_Click(object sender, EventArgs e)
        {
            new FrmSales().ShowDialog();
        }

        #endregion

        #region Categories

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            new FrmAddCategory().ShowDialog();
        }

        private void btnListCategories_Click(object sender, EventArgs e)
        {
            new  FrmCategories().ShowDialog();
        }

        #endregion

        #region Items

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            new FrmAddItem().ShowDialog();
        }

        private void btnListItems_Click(object sender, EventArgs e)
        {
            new FrmItems().ShowDialog();
        }

        private void btnIncreaseItemCount_Click(object sender, EventArgs e)
        {
            new FrmIncreaseItemCount().ShowDialog();
        }

        #endregion

        #region Required

        private void btnRequiredItems_Click(object sender, EventArgs e)
        {
            new FrmRequiredItems().ShowDialog();
        }

        #endregion

        #region Search

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text.FullTrim();
            dgvItemSearch.DataSource = searchText.IsNullOrEmptyOrWhiteSpace()
                ? null
                : ItemManager.SearchItemsByText(searchText);
        }

        #endregion

        #region Timer

        private void timer_Tick(object sender, EventArgs e)
        {
            var requiredItemsCount = ItemManager.GetRequiredItemsCount();
            lblRequired.Text = requiredItemsCount.ToString();
            lblRequired.Visible = requiredItemsCount > 0;
        }

        #endregion

        #endregion

        #region Methods

        #endregion
    }
}