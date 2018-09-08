using System;
using System.Windows.Forms;
using Elra3y.BLL;

namespace Elra3y.PL.Forms
{
    public partial class FrmRequiredItems : FrmMaster
    {
        #region Constructor

        public FrmRequiredItems()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private ItemManager _itemManager;
        private ItemManager ItemManager => _itemManager ?? (_itemManager = new ItemManager());

        #endregion

        #region Events

        private void FrmRequiredItems_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FillGrid();
            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void FillGrid()
        {
            dgvRequiredItems.DataSource = ItemManager.GetRequiredItems();
        }

        #endregion
    }
}