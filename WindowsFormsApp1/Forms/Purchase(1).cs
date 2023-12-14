using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using WindowsFormsApp1.DB;
using WindowsFormsApp1;
using WindowsFormsApp1.Forms;
using DevExpress.XtraTabbedMdi;

namespace WindowsFormsApp1.Forms
{
    public partial class Purchase : DevExpress.XtraEditors.XtraForm
    {
        public Purchase()
        {
            InitializeComponent();

            MainGridBind();

        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "purchaseDB.Days". При необходимости она может быть перемещена или удалена.
            this.daysTableAdapter.Fill(this.purchaseDB.Days);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "purchaseDB.Stock". При необходимости она может быть перемещена или удалена.
            this.purchaseTableAdapter1.Fill(this.purchaseDB.Purchase);
            var dc = new PurchaseLinqDataContext();
        }

        #region DataModel
        private PurchaseLinqDataContext _dc;
        private PurchaseLinqDataContext dc => _dc ?? (_dc = new PurchaseLinqDataContext());

        private void linqInstantFeedbackSource1_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            var dc = new PurchaseLinqDataContext();
            //e.QueryableSource = dc.View_1;
            e.Tag = dc;
        }
        private void MainGridBind()
        {
            var stosk = dc.GetTable<DB.Purchase>();
            gridControl1.DataSource = stosk;

            var size = dc.GetTable<DB.Size>();
            sizeItemLookUpEdit.DataSource = size;
            sizeItemLookUpEdit.DisplayMember = "Size1";
            sizeItemLookUpEdit.ValueMember = "idSize";
            sizeItemLookUpEdit.NullText = "";
            sizeItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Size1", "Size", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});

            var days = dc.GetTable<DB.Days>();
            daysItemLookUpEdit.DataSource = days;
            daysItemLookUpEdit.DisplayMember = "Days1";
            daysItemLookUpEdit.ValueMember = "idDays";
            daysItemLookUpEdit.NullText = "";
            daysItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Days1", "Days", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});

            var broker = dc.GetTable<DB.Broker>();
            brokerItemLookUpEdit.DataSource = broker;
            brokerItemLookUpEdit.DisplayMember = "Broker1";
            brokerItemLookUpEdit.ValueMember = "idBroker";
            brokerItemLookUpEdit.NullText = "";
            brokerItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Broker1", "Broker", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});

            var brokerProcent = dc.GetTable<DB.BrokerProcent>();
            brokerProcentItemLookUpEdit.DataSource = brokerProcent;
            brokerProcentItemLookUpEdit.DisplayMember = "BrokerProcent1";
            brokerProcentItemLookUpEdit.ValueMember = "idBrokerProcent";
            brokerProcentItemLookUpEdit.NullText = "";
            brokerProcentItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BrokerProcent1", "Broker%", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});

            var currency = dc.GetTable<DB.Currency>();
            currencyItemLookUpEdit.DataSource = currency;
            currencyItemLookUpEdit.DisplayMember = "Currency1";
            currencyItemLookUpEdit.ValueMember = "idCurrency";
            currencyItemLookUpEdit.NullText = "";
            currencyItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Currency1", "Currency", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});

            var status = dc.GetTable<DB.PurchaseStatus>();
            statusItemLookUpEdit.DataSource = status;
            statusItemLookUpEdit.DisplayMember = "PurchaseStatus1";
            statusItemLookUpEdit.ValueMember = "idPurchaseStatus";
            statusItemLookUpEdit.NullText = "";
            statusItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurchaseStatus1", "Status", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});

        }
        private void DataUpdate()
        {
            try
            {
                dc.SubmitChanges();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {


        }


        MainForm mf = new MainForm();
        //Form form1 = Application.
        private void toolStripMenuItem_GoToRequest_Click(object sender, EventArgs e)
        {
            //var idRequestValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, colidRequest);
            //if (idRequestValue is int)
            //{
            //    var mainFormMDI = (MainFormMDI)FindForm()?.ParentForm;
            //    mainFormMDI?.FormCall(typeof(RequestInstantFeedbackLoadForm), true, (int)idRequestValue);
            //}

            var mainFormMDI = (MainForm)FindForm()?.ParentForm;
            mainFormMDI?.FormCall(typeof(Split));

        }
        private void barButAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            toolStripMenuItem_GoToRequest_Click(sender, new EventArgs());

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MainGridBind();
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //var row = (CompanySynonyms)gridView1.GetRow(e.RowHandle);
            //var copmany = ((Company)gridView.GetRow(gridView.FocusedRowHandle));
            //row.Company = copmany;
            DataUpdate();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //var row = ((Stock)e.Row);
            //row.idBroker = DataContext.Stock.SingleOrDefault(r => r.idBroker == Tools.CurrentIdUser);
            //row.DateEdit = DateTime.Now;
            DataUpdate();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void purchaseTBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
