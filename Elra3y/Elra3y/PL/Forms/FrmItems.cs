using System;
using Elra3y.BLL;

namespace Elra3y.PL.Forms
{
    public partial class FrmItems : FrmMaster
    {
        #region Constructor

        public FrmItems()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private ItemManager _itemManager;
        private ItemManager ItemManager => _itemManager ?? (_itemManager = new ItemManager());

        #endregion

        #region Events

        private void FrmItems_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void LoadItems()
        {
            dgvItems.DataSource = ItemManager.GetAllItemsVmsOrderedByName();
        }

        #endregion
    }
}