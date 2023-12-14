using DevExpress.XtraEditors;
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
using static WindowsFormsApp1.Forms.Directories;

namespace WindowsFormsApp1.Forms
{
    public partial class Directories : DevExpress.XtraEditors.XtraForm
    {
        public enum RequestType : byte
        {
            All = 0,
            Currency = 1,
            Size = 2,
            Days = 3,
            Broker = 4,
            BrokerProcent = 5,
            Contacts = 6,
            Operations = 7,
            StockCode = 8

        };
        private bool _isFormInit = true;
        private readonly RequestType _requestType = RequestType.Days;
        private int _idRequestFilter = -1;

        public RequestType FormType => _requestType;
        public Directories()
        {
            InitializeComponent();
            var dc = new PurchaseLinqDataContext();
            MainGridBind();
        }


        public Directories(int requestType) : this()
        {
            //_requestType = !requestType  ? RequestType.Days : RequestType.Broker;
            switch (requestType)
            {
                case 1:
                    _requestType = RequestType.Currency;
                    Text = "Currency";
                    gridControl1.DataSource = dc.GetTable<DB.Currency>();
                    break;
                case 2:
                    _requestType = RequestType.Size;
                    Text = "Size";
                    gridControl1.DataSource = dc.GetTable<DB.Size>();
                    break;
                case 3:
                    _requestType = RequestType.Days;
                    Text = "Days";
                    gridControl1.DataSource = dc.GetTable<DB.Days>();
                    break;
                case 4:
                    _requestType = RequestType.Broker;
                    Text = "Broker";
                    gridControl1.DataSource = dc.GetTable<DB.Broker>();
                    break;
                case 5:
                    _requestType = RequestType.BrokerProcent;
                    Text = "Proker procent";
                    gridControl1.DataSource = dc.GetTable<DB.BrokerProcent>();
                    break;
                case 6:
                    _requestType = RequestType.Contacts;
                    Text = "Contacts";
                    //gridControl1.DataSource = dc.GetTable<DB.Contacts>();
                    break;
                case 7:
                    _requestType = RequestType.Operations;
                    Text = "Operations";
                    //gridControl1.DataSource = dc.GetTable<DB.Operations>();
                    break;
                case 8:
                    _requestType = RequestType.StockCode;
                    Text = "Stock code";
                    //gridControl1.DataSource = dc.GetTable<DB.StockCode>();
                    break;
            }
            //autoPassCtrlLinq1.Dock = DockStyle.Fill;
            //personPassCtrlLinq1.Dock = DockStyle.Fill;

            //autoPassCtrlLinq1.Visible = _requestType == RequestType.Auto;
            //personPassCtrlLinq1.Visible = _requestType == RequestType.Person;

            //Text = _requestType == RequestType.Days ? "Заявки по транспорту" : "Заявки по персоналу";
        }

        //public Directories(bool requestType, int idRequest) : this(requestType)
        //{
        //    _idRequestFilter = idRequest;
        //}

        private PurchaseLinqDataContext _dc;
        private PurchaseLinqDataContext dc => _dc ?? (_dc = new PurchaseLinqDataContext());

        private void linqInstantFeedbackSource1_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            var dc = new PurchaseLinqDataContext();
            e.QueryableSource = dc.View_1;
            e.Tag = dc;
        }
        private void MainGridBind()
        {
            //var stosk = dc.GetTable<DB.Currency>();
            //gridControl1.DataSource = stosk;
        }

        private void Directories_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "purchaseDB.Currency". При необходимости она может быть перемещена или удалена.
                        //this.currencyTableAdapter.Fill(this.purchaseDB.Currency);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            dc.SubmitChanges();
        }
    }
}