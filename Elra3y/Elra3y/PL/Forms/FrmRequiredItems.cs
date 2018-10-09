using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Elra3y.BLL;
using Elra3y.DAL.VMs;

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
        private List<RequiredItemVm> _requiredItemVms;

        private List<RequiredItemVm> RequiredItemVms =>
            _requiredItemVms ?? (_requiredItemVms = ItemManager.GetRequiredItems());

        #endregion

        #region Events

        private void FrmRequiredItems_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FillGrid(null);
            Cursor = Cursors.Default;
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var radSender = sender as RadioButton;
            if (radSender != null && int.TryParse(radSender.Text, out int minCount))
                FillGrid(minCount);
            else
                FillGrid(null);
            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void FillGrid(int? minCount)
        {
            dgvRequiredItems.DataSource =
                RequiredItemVms.Where(item => minCount == null || item.CurrentCount == minCount.Value).ToList();
        }

        #endregion
    }
}