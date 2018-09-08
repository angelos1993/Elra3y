using System;
using System.Linq;
using System.Windows.Forms;
using Elra3y.BLL;

namespace Elra3y.PL.Forms
{
    public partial class FrmSales : FrmMaster
    {
        #region Constructor

        public FrmSales()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private SaleManager _saleManager;
        private SaleManager SaleManager => _saleManager ?? (_saleManager = new SaleManager());

        #endregion

        #region Events

        private void FrmSales_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            dtSaleDate.Value = DateTime.Now;
            FillGrid();
            Cursor = Cursors.Default;
        }

        private void dtSaleDate_ValueChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FillGrid();
            Cursor = Cursors.Default;
        }

        #endregion

        #region Methods

        private void FillGrid()
        {
            var sales = SaleManager.GetSalesByDate(dtSaleDate.Value);
            dgvSales.DataSource = sales;
            lblTotalSales.Text = $@"إجمالي المبيعات: {sales.Sum(sale => sale.Price)}";
        }

        #endregion
    }
}