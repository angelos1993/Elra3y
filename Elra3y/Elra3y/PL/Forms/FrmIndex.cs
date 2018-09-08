using DevComponents.DotNetBar;

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

        #endregion

        #region Events

        #region Sales

        private void btnNewSale_Click(object sender, System.EventArgs e)
        {
            new FrmAddSale().ShowDialog();
        }

        private void btnListSales_Click(object sender, System.EventArgs e)
        {
            new FrmSales().ShowDialog();
        }

        #endregion

        #region Categories

        private void btnAddCategory_Click(object sender, System.EventArgs e)
        {
            new FrmAddCategory().ShowDialog();
        }

        private void btnListCategories_Click(object sender, System.EventArgs e)
        {
            new  FrmCategories().ShowDialog();
        }

        #endregion

        #region Items

        private void btnAddItem_Click(object sender, System.EventArgs e)
        {
            new FrmAddItem().ShowDialog();
        }

        private void btnListItems_Click(object sender, System.EventArgs e)
        {
            new FrmItems().ShowDialog();
        }

        private void btnIncreaseItemCount_Click(object sender, System.EventArgs e)
        {
            new FrmIncreaseItemCount().ShowDialog();
        }

        #endregion

        #endregion

        #region Methods

        #endregion
    }
}