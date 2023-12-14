namespace WindowsFormsApp1.Forms
{
    partial class Purchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.linqInstantFeedbackSource1 = new DevExpress.Data.Linq.LinqInstantFeedbackSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidPurchase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLotNr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInrCt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInrTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatePurch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppliner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidPurchaseStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colidCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.currencyItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colidSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sizeItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colidDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.daysItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colidBroker = new DevExpress.XtraGrid.Columns.GridColumn();
            this.brokerItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colidBrokerProcent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.brokerProcentItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.daystemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.brokerItemSearchLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemSearchLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.stockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseDB = new WindowsFormsApp1.DB.PurchaseDB();
            this.daysBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.daysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barButAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barButApprove = new DevExpress.XtraBars.BarButtonItem();
            this.barButUnApprove = new DevExpress.XtraBars.BarButtonItem();
            this.barButPassReject = new DevExpress.XtraBars.BarButtonItem();
            this.barButPassUnReject = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckFindPanel = new DevExpress.XtraBars.BarCheckItem();
            this.barButApprovalNote = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.imageCollection48 = new DevExpress.Utils.ImageCollection(this.components);
            this.imageCollection24 = new DevExpress.Utils.ImageCollection(this.components);
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.daysTableAdapter = new WindowsFormsApp1.DB.PurchaseDBTableAdapters.DaysTableAdapter();
            this.daysBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.purchaseTableAdapter1 = new WindowsFormsApp1.DB.PurchaseDBTableAdapters.PurchaseTableAdapter();
            this.brokerProcentTableAdapter1 = new WindowsFormsApp1.DB.PurchaseDBTableAdapters.BrokerProcentTableAdapter();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brokerItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brokerProcentItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daystemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brokerItemSearchLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.daystemButtonEdit1,
            this.brokerItemSearchLookUpEdit,
            this.repositoryItemCheckedComboBoxEdit1,
            this.daysItemLookUpEdit,
            this.sizeItemLookUpEdit,
            this.repositoryItemComboBox1,
            this.repositoryItemSearchLookUpEdit2,
            this.brokerItemLookUpEdit,
            this.brokerProcentItemLookUpEdit,
            this.currencyItemLookUpEdit,
            this.statusItemLookUpEdit});
            this.gridControl1.Size = new System.Drawing.Size(1540, 640);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // linqInstantFeedbackSource1
            // 
            this.linqInstantFeedbackSource1.DesignTimeElementType = typeof(WindowsFormsApp1.DB.View_1);
            this.linqInstantFeedbackSource1.KeyExpression = "idPurchase";
            this.linqInstantFeedbackSource1.GetQueryable += new System.EventHandler<DevExpress.Data.Linq.GetQueryableEventArgs>(this.linqInstantFeedbackSource1_GetQueryable);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidPurchase,
            this.colLotNr,
            this.colCts,
            this.colInrCt,
            this.colInrTotal,
            this.colRate,
            this.colCt,
            this.colTotal,
            this.colDatePurch,
            this.colDueDate,
            this.colSuppliner,
            this.colCommission,
            this.colRemarks,
            this.colidPurchaseStatus,
            this.colidCurrency,
            this.colidSize,
            this.colidDays,
            this.colidBroker,
            this.colidBrokerProcent});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.RowCountChanged += new System.EventHandler(this.gridView1_RowCountChanged);
            // 
            // colidPurchase
            // 
            this.colidPurchase.FieldName = "idPurchase";
            this.colidPurchase.Name = "colidPurchase";
            this.colidPurchase.Width = 49;
            // 
            // colLotNr
            // 
            this.colLotNr.FieldName = "LotNr";
            this.colLotNr.Name = "colLotNr";
            this.colLotNr.Visible = true;
            this.colLotNr.VisibleIndex = 1;
            this.colLotNr.Width = 49;
            // 
            // colCts
            // 
            this.colCts.FieldName = "Cts";
            this.colCts.Name = "colCts";
            this.colCts.Visible = true;
            this.colCts.VisibleIndex = 2;
            this.colCts.Width = 49;
            // 
            // colInrCt
            // 
            this.colInrCt.FieldName = "InrCt";
            this.colInrCt.Name = "colInrCt";
            this.colInrCt.Visible = true;
            this.colInrCt.VisibleIndex = 3;
            this.colInrCt.Width = 49;
            // 
            // colInrTotal
            // 
            this.colInrTotal.FieldName = "InrTotal";
            this.colInrTotal.Name = "colInrTotal";
            this.colInrTotal.Visible = true;
            this.colInrTotal.VisibleIndex = 4;
            this.colInrTotal.Width = 49;
            // 
            // colRate
            // 
            this.colRate.FieldName = "Rate";
            this.colRate.Name = "colRate";
            this.colRate.Visible = true;
            this.colRate.VisibleIndex = 5;
            this.colRate.Width = 49;
            // 
            // colCt
            // 
            this.colCt.FieldName = "Ct";
            this.colCt.Name = "colCt";
            this.colCt.Visible = true;
            this.colCt.VisibleIndex = 6;
            this.colCt.Width = 49;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 7;
            this.colTotal.Width = 49;
            // 
            // colDatePurch
            // 
            this.colDatePurch.FieldName = "DatePurch";
            this.colDatePurch.Name = "colDatePurch";
            this.colDatePurch.Visible = true;
            this.colDatePurch.VisibleIndex = 8;
            this.colDatePurch.Width = 49;
            // 
            // colDueDate
            // 
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.Visible = true;
            this.colDueDate.VisibleIndex = 9;
            this.colDueDate.Width = 49;
            // 
            // colSuppliner
            // 
            this.colSuppliner.FieldName = "Suppliner";
            this.colSuppliner.Name = "colSuppliner";
            this.colSuppliner.Visible = true;
            this.colSuppliner.VisibleIndex = 10;
            this.colSuppliner.Width = 49;
            // 
            // colCommission
            // 
            this.colCommission.FieldName = "Commission";
            this.colCommission.Name = "colCommission";
            this.colCommission.Visible = true;
            this.colCommission.VisibleIndex = 11;
            this.colCommission.Width = 49;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 12;
            this.colRemarks.Width = 49;
            // 
            // colidPurchaseStatus
            // 
            this.colidPurchaseStatus.Caption = "Status";
            this.colidPurchaseStatus.ColumnEdit = this.statusItemLookUpEdit;
            this.colidPurchaseStatus.FieldName = "idPurchaseStatus";
            this.colidPurchaseStatus.Name = "colidPurchaseStatus";
            this.colidPurchaseStatus.Visible = true;
            this.colidPurchaseStatus.VisibleIndex = 13;
            this.colidPurchaseStatus.Width = 49;
            // 
            // statusItemLookUpEdit
            // 
            this.statusItemLookUpEdit.AutoHeight = false;
            this.statusItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusItemLookUpEdit.Name = "statusItemLookUpEdit";
            // 
            // colidCurrency
            // 
            this.colidCurrency.Caption = "Currency";
            this.colidCurrency.ColumnEdit = this.currencyItemLookUpEdit;
            this.colidCurrency.FieldName = "idCurrency";
            this.colidCurrency.Name = "colidCurrency";
            this.colidCurrency.Visible = true;
            this.colidCurrency.VisibleIndex = 14;
            this.colidCurrency.Width = 49;
            // 
            // currencyItemLookUpEdit
            // 
            this.currencyItemLookUpEdit.AutoHeight = false;
            this.currencyItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.currencyItemLookUpEdit.Name = "currencyItemLookUpEdit";
            // 
            // colidSize
            // 
            this.colidSize.Caption = "Size";
            this.colidSize.ColumnEdit = this.sizeItemLookUpEdit;
            this.colidSize.FieldName = "idSize";
            this.colidSize.Name = "colidSize";
            this.colidSize.Visible = true;
            this.colidSize.VisibleIndex = 15;
            this.colidSize.Width = 49;
            // 
            // sizeItemLookUpEdit
            // 
            this.sizeItemLookUpEdit.AutoHeight = false;
            this.sizeItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sizeItemLookUpEdit.Name = "sizeItemLookUpEdit";
            // 
            // colidDays
            // 
            this.colidDays.Caption = "Days";
            this.colidDays.ColumnEdit = this.daysItemLookUpEdit;
            this.colidDays.FieldName = "idDays";
            this.colidDays.Name = "colidDays";
            this.colidDays.Visible = true;
            this.colidDays.VisibleIndex = 16;
            this.colidDays.Width = 49;
            // 
            // daysItemLookUpEdit
            // 
            this.daysItemLookUpEdit.AutoHeight = false;
            this.daysItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.daysItemLookUpEdit.Name = "daysItemLookUpEdit";
            // 
            // colidBroker
            // 
            this.colidBroker.Caption = "Broker";
            this.colidBroker.ColumnEdit = this.brokerItemLookUpEdit;
            this.colidBroker.FieldName = "idBroker";
            this.colidBroker.Name = "colidBroker";
            this.colidBroker.Visible = true;
            this.colidBroker.VisibleIndex = 17;
            this.colidBroker.Width = 63;
            // 
            // brokerItemLookUpEdit
            // 
            this.brokerItemLookUpEdit.AutoHeight = false;
            this.brokerItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.brokerItemLookUpEdit.Name = "brokerItemLookUpEdit";
            // 
            // colidBrokerProcent
            // 
            this.colidBrokerProcent.Caption = "Broker%";
            this.colidBrokerProcent.ColumnEdit = this.brokerProcentItemLookUpEdit;
            this.colidBrokerProcent.FieldName = "idBrokerProcent";
            this.colidBrokerProcent.Name = "colidBrokerProcent";
            this.colidBrokerProcent.Visible = true;
            this.colidBrokerProcent.VisibleIndex = 18;
            this.colidBrokerProcent.Width = 36;
            // 
            // brokerProcentItemLookUpEdit
            // 
            this.brokerProcentItemLookUpEdit.AutoHeight = false;
            this.brokerProcentItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.brokerProcentItemLookUpEdit.Name = "brokerProcentItemLookUpEdit";
            // 
            // daystemButtonEdit1
            // 
            this.daystemButtonEdit1.AutoHeight = false;
            this.daystemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.daystemButtonEdit1.Name = "daystemButtonEdit1";
            this.daystemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // brokerItemSearchLookUpEdit
            // 
            this.brokerItemSearchLookUpEdit.AutoHeight = false;
            this.brokerItemSearchLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.brokerItemSearchLookUpEdit.Name = "brokerItemSearchLookUpEdit";
            this.brokerItemSearchLookUpEdit.PopupView = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemSearchLookUpEdit2
            // 
            this.repositoryItemSearchLookUpEdit2.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit2.Name = "repositoryItemSearchLookUpEdit2";
            this.repositoryItemSearchLookUpEdit2.PopupView = this.repositoryItemSearchLookUpEdit2View;
            // 
            // repositoryItemSearchLookUpEdit2View
            // 
            this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
            this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // stockBindingSource1
            // 
            this.stockBindingSource1.DataMember = "Purchase";
            this.stockBindingSource1.DataSource = this.purchaseDBBindingSource;
            // 
            // purchaseDBBindingSource
            // 
            this.purchaseDBBindingSource.DataSource = this.purchaseDB;
            this.purchaseDBBindingSource.Position = 0;
            // 
            // purchaseDB
            // 
            this.purchaseDB.DataSetName = "PurchaseDB";
            this.purchaseDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // daysBindingSource2
            // 
            this.daysBindingSource2.DataMember = "Days";
            this.daysBindingSource2.DataSource = this.purchaseDBBindingSource;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Purchase";
            this.stockBindingSource.DataSource = this.purchaseDBBindingSource;
            // 
            // purchaseTBindingSource
            // 
            this.purchaseTBindingSource.DataMember = "PurchaseT";
            this.purchaseTBindingSource.DataSource = this.purchaseDBBindingSource;
            this.purchaseTBindingSource.CurrentChanged += new System.EventHandler(this.purchaseTBindingSource_CurrentChanged);
            // 
            // purchaseTBindingSource1
            // 
            this.purchaseTBindingSource1.DataMember = "PurchaseT";
            this.purchaseTBindingSource1.DataSource = this.purchaseDBBindingSource;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.purchaseDBBindingSource;
            // 
            // colSupplier
            // 
            this.colSupplier.Caption = "Supplier";
            this.colSupplier.FieldName = "PurchaseT.Supplier";
            this.colSupplier.Name = "colSupplier";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Status";
            this.gridColumn8.FieldName = "PurchaseT.Status";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // bar1
            // 
            this.bar1.BarName = "Сервис";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Сервис";
            // 
            // bar2
            // 
            this.bar2.BarName = "Сервис";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableClose = true;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Сервис";
            // 
            // bar3
            // 
            this.bar3.BarName = "Сервис";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DisableClose = true;
            this.bar3.OptionsBar.DisableCustomization = true;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Сервис";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButAdd,
            this.barButDelete,
            this.barButRefresh,
            this.barButPrint,
            this.barButSave,
            this.barButApprove,
            this.barButUnApprove,
            this.barButPassReject,
            this.barButPassUnReject,
            this.barCheckFindPanel,
            this.barButApprovalNote,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem5});
            this.barManager.MainMenu = this.bar4;
            this.barManager.MaxItemId = 18;
            this.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize;
            // 
            // bar4
            // 
            this.bar4.BarName = "Сервис";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.FloatSize = new System.Drawing.Size(50, 0);
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButSave, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DisableClose = true;
            this.bar4.OptionsBar.DisableCustomization = true;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Сервис";
            // 
            // barButAdd
            // 
            this.barButAdd.Caption = "Split";
            this.barButAdd.Id = 0;
            this.barButAdd.ImageOptions.DisabledImageIndex = 0;
            this.barButAdd.ImageOptions.DisabledLargeImageIndex = 0;
            this.barButAdd.ImageOptions.ImageIndex = 1;
            this.barButAdd.ImageOptions.LargeImageIndex = 1;
            this.barButAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButAdd.ImageOptions.SvgImage")));
            this.barButAdd.Name = "barButAdd";
            this.barButAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButAdd_ItemClick);
            // 
            // barButSave
            // 
            this.barButSave.Caption = "Stock";
            this.barButSave.Id = 4;
            this.barButSave.ImageOptions.DisabledImageIndex = 26;
            this.barButSave.ImageOptions.DisabledLargeImageIndex = 26;
            this.barButSave.ImageOptions.ImageIndex = 27;
            this.barButSave.ImageOptions.LargeImageIndex = 27;
            this.barButSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButSave.ImageOptions.SvgImage")));
            this.barButSave.Name = "barButSave";
            this.barButSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Delete";
            this.barButtonItem2.Id = 16;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Refresh";
            this.barButtonItem5.Id = 17;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1540, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 664);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1540, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 640);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1540, 24);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 640);
            // 
            // barButDelete
            // 
            this.barButDelete.Caption = "Удалить";
            this.barButDelete.Id = 1;
            this.barButDelete.ImageOptions.DisabledImageIndex = 24;
            this.barButDelete.ImageOptions.DisabledLargeImageIndex = 24;
            this.barButDelete.ImageOptions.ImageIndex = 25;
            this.barButDelete.ImageOptions.LargeImageIndex = 25;
            this.barButDelete.Name = "barButDelete";
            // 
            // barButRefresh
            // 
            this.barButRefresh.Caption = "Обновить";
            this.barButRefresh.Id = 2;
            this.barButRefresh.ImageOptions.DisabledImageIndex = 88;
            this.barButRefresh.ImageOptions.DisabledLargeImageIndex = 88;
            this.barButRefresh.ImageOptions.ImageIndex = 89;
            this.barButRefresh.ImageOptions.LargeImageIndex = 89;
            this.barButRefresh.Name = "barButRefresh";
            // 
            // barButPrint
            // 
            this.barButPrint.Caption = "Печать";
            this.barButPrint.Id = 3;
            this.barButPrint.ImageOptions.DisabledImageIndex = 84;
            this.barButPrint.ImageOptions.DisabledLargeImageIndex = 84;
            this.barButPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButPrint.ImageOptions.Image")));
            this.barButPrint.ImageOptions.ImageIndex = 85;
            this.barButPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButPrint.ImageOptions.LargeImage")));
            this.barButPrint.ImageOptions.LargeImageIndex = 85;
            this.barButPrint.Name = "barButPrint";
            // 
            // barButApprove
            // 
            this.barButApprove.Caption = "Delete";
            this.barButApprove.Id = 5;
            this.barButApprove.ImageOptions.DisabledImageIndex = 68;
            this.barButApprove.ImageOptions.DisabledLargeImageIndex = 68;
            this.barButApprove.ImageOptions.ImageIndex = 69;
            this.barButApprove.ImageOptions.LargeImageIndex = 69;
            this.barButApprove.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButApprove.ImageOptions.SvgImage")));
            this.barButApprove.Name = "barButApprove";
            this.barButApprove.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.barButApprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButUnApprove
            // 
            this.barButUnApprove.Caption = "Снять пометки";
            this.barButUnApprove.Id = 6;
            this.barButUnApprove.ImageOptions.DisabledImageIndex = 18;
            this.barButUnApprove.ImageOptions.DisabledLargeImageIndex = 18;
            this.barButUnApprove.ImageOptions.ImageIndex = 19;
            this.barButUnApprove.ImageOptions.LargeImageIndex = 19;
            this.barButUnApprove.Name = "barButUnApprove";
            this.barButUnApprove.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing;
            // 
            // barButPassReject
            // 
            this.barButPassReject.Caption = "Изъять пропуск";
            this.barButPassReject.Id = 7;
            this.barButPassReject.ImageOptions.DisabledImageIndex = 54;
            this.barButPassReject.ImageOptions.DisabledLargeImageIndex = 54;
            this.barButPassReject.ImageOptions.ImageIndex = 55;
            this.barButPassReject.ImageOptions.LargeImageIndex = 55;
            this.barButPassReject.Name = "barButPassReject";
            // 
            // barButPassUnReject
            // 
            this.barButPassUnReject.Caption = "Вернуть изъятый пропуск";
            this.barButPassUnReject.Id = 8;
            this.barButPassUnReject.ImageOptions.DisabledImageIndex = 106;
            this.barButPassUnReject.ImageOptions.DisabledLargeImageIndex = 106;
            this.barButPassUnReject.ImageOptions.ImageIndex = 107;
            this.barButPassUnReject.ImageOptions.LargeImageIndex = 107;
            this.barButPassUnReject.Name = "barButPassUnReject";
            // 
            // barCheckFindPanel
            // 
            this.barCheckFindPanel.Caption = "Показать / скрыть панель поиска";
            this.barCheckFindPanel.Id = 9;
            this.barCheckFindPanel.ImageOptions.DisabledImageIndex = 120;
            this.barCheckFindPanel.ImageOptions.DisabledLargeImageIndex = 120;
            this.barCheckFindPanel.ImageOptions.ImageIndex = 121;
            this.barCheckFindPanel.ImageOptions.LargeImageIndex = 121;
            this.barCheckFindPanel.Name = "barCheckFindPanel";
            // 
            // barButApprovalNote
            // 
            this.barButApprovalNote.Caption = "barButApprovalNote";
            this.barButApprovalNote.Id = 13;
            this.barButApprovalNote.ImageOptions.DisabledImageIndex = 96;
            this.barButApprovalNote.ImageOptions.DisabledLargeImageIndex = 96;
            this.barButApprovalNote.ImageOptions.ImageIndex = 97;
            this.barButApprovalNote.ImageOptions.LargeImageIndex = 97;
            this.barButApprovalNote.Name = "barButApprovalNote";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 15;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // imageCollection48
            // 
            this.imageCollection48.ImageSize = new System.Drawing.Size(48, 48);
            this.imageCollection48.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection48.ImageStream")));
            this.imageCollection48.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageCollection24
            // 
            this.imageCollection24.ImageSize = new System.Drawing.Size(24, 24);
            this.imageCollection24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection24.ImageStream")));
            this.imageCollection24.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem2";
            this.barButtonItem3.Hint = "Delete";
            this.barButtonItem3.Id = 16;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem2";
            this.barButtonItem4.Hint = "Delete";
            this.barButtonItem4.Id = 16;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // daysTableAdapter
            // 
            this.daysTableAdapter.ClearBeforeFill = true;
            // 
            // daysBindingSource1
            // 
            this.daysBindingSource1.DataSource = this.daysBindingSource2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "idBrokerProcent";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 19;
            this.gridColumn1.Width = 36;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "idBrokerProcent";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 19;
            this.gridColumn2.Width = 36;
            // 
            // gridColumn3
            // 
            this.gridColumn3.ColumnEdit = this.currencyItemLookUpEdit;
            this.gridColumn3.FieldName = "idCurrency";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 15;
            this.gridColumn3.Width = 49;
            // 
            // gridColumn4
            // 
            this.gridColumn4.ColumnEdit = this.currencyItemLookUpEdit;
            this.gridColumn4.FieldName = "idCurrency";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 15;
            this.gridColumn4.Width = 49;
            // 
            // purchaseTableAdapter1
            // 
            this.purchaseTableAdapter1.ClearBeforeFill = true;
            // 
            // brokerProcentTableAdapter1
            // 
            this.brokerProcentTableAdapter1.ClearBeforeFill = true;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = null;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 664);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Purchase.IconOptions.SvgImage")));
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brokerItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brokerProcentItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daystemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brokerItemSearchLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit daystemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit brokerItemSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit daysItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit sizeItemLookUpEdit;
        private System.Windows.Forms.BindingSource purchaseDBBindingSource;
        private DB.PurchaseDB purchaseDB;
        private System.Windows.Forms.BindingSource purchaseTBindingSource1;
        private System.Windows.Forms.BindingSource purchaseTBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarButtonItem barButAdd;
        private DevExpress.XtraBars.BarButtonItem barButDelete;
        private DevExpress.XtraBars.BarButtonItem barButSave;
        private DevExpress.XtraBars.BarButtonItem barButRefresh;
        private DevExpress.XtraBars.BarButtonItem barButApprove;
        private DevExpress.XtraBars.BarButtonItem barButUnApprove;
        private DevExpress.XtraBars.BarButtonItem barButPassReject;
        private DevExpress.XtraBars.BarButtonItem barButPassUnReject;
        private DevExpress.XtraBars.BarButtonItem barButPrint;
        private DevExpress.XtraBars.BarCheckItem barCheckFindPanel;
        private DevExpress.XtraBars.BarButtonItem barButApprovalNote;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection imageCollection48;
        private DevExpress.Utils.ImageCollection imageCollection24;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private DevExpress.Data.Linq.LinqInstantFeedbackSource linqInstantFeedbackSource1;
        private System.Windows.Forms.BindingSource stockBindingSource1;
        private System.Windows.Forms.BindingSource daysBindingSource;
        private DB.PurchaseDBTableAdapters.DaysTableAdapter daysTableAdapter;
        private System.Windows.Forms.BindingSource daysBindingSource1;
        private System.Windows.Forms.BindingSource daysBindingSource2;
        private DevExpress.XtraGrid.Columns.GridColumn colidPurchase;
        private DevExpress.XtraGrid.Columns.GridColumn colLotNr;
        private DevExpress.XtraGrid.Columns.GridColumn colCts;
        private DevExpress.XtraGrid.Columns.GridColumn colInrCt;
        private DevExpress.XtraGrid.Columns.GridColumn colInrTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colRate;
        private DevExpress.XtraGrid.Columns.GridColumn colCt;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colDatePurch;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppliner;
        private DevExpress.XtraGrid.Columns.GridColumn colCommission;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colidPurchaseStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colidCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colidSize;
        private DevExpress.XtraGrid.Columns.GridColumn colidDays;
        private DevExpress.XtraGrid.Columns.GridColumn colidBroker;
        private DevExpress.XtraGrid.Columns.GridColumn colidBrokerProcent;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit brokerItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit brokerProcentItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit currencyItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit statusItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DB.PurchaseDBTableAdapters.PurchaseTableAdapter purchaseTableAdapter1;
        private DB.PurchaseDBTableAdapters.BrokerProcentTableAdapter brokerProcentTableAdapter1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}