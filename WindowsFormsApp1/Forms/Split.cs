using DevExpress.Data;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views;
using DevExpress.XtraGrid.Columns;

namespace WindowsFormsApp1 
{
    public partial class Split : DevExpress.XtraEditors.XtraForm
    {
        public Split()
        {
            InitializeComponent();

            gridView1.OptionsBehavior.Editable = false;

            #region Parcels
            GridColumnSummaryItem parCts = new GridColumnSummaryItem();
            parCts.SummaryType = SummaryItemType.Sum;
            parCts.FieldName = "Cts";
            parCts.DisplayFormat = "{0}";

            GridColumnSummaryItem parTotal = new GridColumnSummaryItem();
            parTotal.SummaryType = SummaryItemType.Sum;
            parTotal.FieldName = "Total";
            parTotal.DisplayFormat = "{0}";

            GridColumnSummaryItem parCt = new GridColumnSummaryItem();
            parCt.SummaryType = SummaryItemType.Custom;
            parCt.FieldName = "Ct";
            parCt.DisplayFormat = "{0:#.##}";

            gridView1.CustomSummaryCalculate += (sender, e) => {
                if (e.IsTotalSummary)
                {
                    GridView view = sender as GridView;
                    switch (e.SummaryProcess)
                    {
                        //// Calculation entry point
                        //case CustomSummaryProcess.Start:
                        //    dateCount = 0;
                        //    break;
                        //// Consequent calculations
                        //case CustomSummaryProcess.Calculate:
                        //    DateTime value = Convert.ToDateTime(view.GetRowCellValue(e.RowHandle, view.Columns["RecordDate"]));
                        //    DateTime current = DateTime.Now;
                        //    System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.CurrentCulture;
                        //    // Retrieve weeks
                        //    var valueWeek = cul.Calendar.GetWeekOfYear(
                        //        value,
                        //        System.Globalization.CalendarWeekRule.FirstDay,
                        //        DayOfWeek.Monday);
                        //    var currentWeek = cul.Calendar.GetWeekOfYear(
                        //        current,
                        //        System.Globalization.CalendarWeekRule.FirstDay,
                        //        DayOfWeek.Monday);
                        //    if (valueWeek == currentWeek) dateCount++;
                        //    break;
                        // Final summary value
                        case CustomSummaryProcess.Finalize:
                            e.TotalValue = Convert.ToDouble(parTotal.SummaryValue) / Convert.ToDouble(parCts.SummaryValue);
                            break;
                    }
                }
            };


            gridView1.Columns["Cts"].Summary.Add(parCts);
            gridView1.Columns["Total"].Summary.Add(parTotal);
            gridView1.Columns["Ct"].Summary.Add(parCt);
            gridView1.OptionsView.ShowFooter = true;
            #endregion

            #region Split
            GridColumnSummaryItem splCts = new GridColumnSummaryItem();
            splCts.SummaryType = SummaryItemType.Sum;
            splCts.FieldName = "SpCTS";
            splCts.DisplayFormat = "Sum = {0:n2}";

            GridColumnSummaryItem splTotal = new GridColumnSummaryItem();
            splTotal.SummaryType = SummaryItemType.Sum;
            splTotal.FieldName = "SpTotal";
            splTotal.DisplayFormat = "Sum = {0:n2}";

            GridColumnSummaryItem splCt = new GridColumnSummaryItem();
            splCt.SummaryType = SummaryItemType.Sum;
            splCt.FieldName = "SpCt";
            splCt.DisplayFormat = "Total / CTS = {0:n2}";




            //GridColumnSummaryItem splLossCts = new GridColumnSummaryItem();
            splLossCts.SummaryType = SummaryItemType.Custom;
            splLossCts.FieldName = "SpCTS";
            splLossCts.DisplayFormat = "Loss = {0:n2}";


            //GridColumnSummaryItem splLossTotal = new GridColumnSummaryItem();
            splLossTotal.SummaryType = SummaryItemType.Custom;
            splLossTotal.FieldName = "SpTotal";
            splLossTotal.DisplayFormat = "Loss = {0:n2}";


            //GridColumnSummaryItem splLossCt = new GridColumnSummaryItem();
            splLossCt.SummaryType = SummaryItemType.Custom;
            splLossCt.FieldName = "SpCt";
            splLossCt.DisplayFormat = "Loss Total / CTS = {0:n2}";

            gridView2.CustomSummaryCalculate += (sender, e) =>
            {
                string summaryID = Convert.ToString((e.Item as GridSummaryItem).FieldName);
                if (e.IsTotalSummary)
                {
                    GridView view = sender as GridView;
                    switch (summaryID)
                    {
                        case "SpCTS":
                            e.TotalValue = Convert.ToDouble(parCts.SummaryValue) - Convert.ToDouble(splCts.SummaryValue);
                            break;
                        case "SpTotal":
                            e.TotalValue = Convert.ToDouble(parTotal.SummaryValue) - Convert.ToDouble(splTotal.SummaryValue);
                            break;
                        case "SpCt":
                            double valueSpCt = (Convert.ToDouble(parTotal.SummaryValue) - Convert.ToDouble(splTotal.SummaryValue)) / (Convert.ToDouble(parCts.SummaryValue) - Convert.ToDouble(splCts.SummaryValue));
                            e.TotalValue = Double.IsNaN(valueSpCt) ? 0.00 : valueSpCt;
                            break;
                    }
                }
            };

            gridView2.Columns["SpCTS"].Summary.Add(splCts);
            gridView2.Columns["SpTotal"].Summary.Add(splTotal);
            gridView2.Columns["SpCt"].Summary.Add(splCt);

            gridView2.Columns["SpCTS"].Summary.Add(splLossCts);
            gridView2.Columns["SpTotal"].Summary.Add(splLossTotal);
            gridView2.Columns["SpCt"].Summary.Add(splLossCt);

            gridView2.OptionsView.ShowFooter = true;
            #endregion

            #region Заполнение данными
            DataTable dataTable2 = new DataTable();
            dataTable2.Columns.Add("LotNr", typeof(string));
            dataTable2.Columns.Add("idSize", typeof(string));
            dataTable2.Columns.Add("Cts", typeof(float));
            dataTable2.Columns.Add("Ct", typeof(float));
            dataTable2.Columns.Add("Total", typeof(float));
            dataTable2.Columns.Add("Supplier", typeof(string));
            dataTable2.Rows.Add("DEC22_1", "2.70-3.20", 15.26, 457, 6986.51, "SERGEY");
            dataTable2.Rows.Add("DEC22_3", "0.60-1.25", 27.16, 457, 12434.70, "SERGEY");
            gridControl1.DataSource = dataTable2;

            DataTable dataTable1 = new DataTable();
            dataTable1.Columns.Add("StockId", typeof(string));
            dataTable1.Columns.Add("SpCTS", typeof(float));
            dataTable1.Columns.Add("SpCt", typeof(float));
            dataTable1.Columns.Add("SpTotal", typeof(float));
            gridControl2.DataSource = dataTable1;

            DataTable dataTable3 = new DataTable();
            dataTable3.Columns.Add("OldCTS", typeof(float));
            dataTable3.Columns.Add("OldSpCt", typeof(float));
            dataTable3.Columns.Add("OldSpTotal", typeof(float));
            gridControl3.DataSource = dataTable3;


            DataTable dataTable4 = new DataTable();
            dataTable4.Columns.Add("NewSpCTS", typeof(float));
            dataTable4.Columns.Add("NewSpCt", typeof(float));
            dataTable4.Columns.Add("NewSpTotal", typeof(float));
            gridControl4.DataSource = dataTable4;
            #endregion
        }
        GridColumnSummaryItem splLossCts = new GridColumnSummaryItem();
        GridColumnSummaryItem splLossTotal = new GridColumnSummaryItem();
        GridColumnSummaryItem splLossCt = new GridColumnSummaryItem();

        private void Split_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "purchaseDB.Purchase". При необходимости она может быть перемещена или удалена.
            //this.purchaseTableAdapter.Fill(this.purchaseDB.Purchase);

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Console.WriteLine(Convert.ToDouble(gridView2.GetRowCellValue(e.RowHandle, colSpCt)) + "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            if (gridView2.GetRowCellValue(e.RowHandle, colSpCt) != null && gridView2.GetRowCellValue(e.RowHandle, colSpCTS) != null)
            {
                gridView2.SetRowCellValue(e.RowHandle, colSpTotal, Convert.ToDouble(gridView2.GetRowCellValue(e.RowHandle, colSpCt)) * Convert.ToDouble(gridView2.GetRowCellValue(e.RowHandle, colSpCTS)));
            }
        }

        private void gridView2_ColumnChanged(object sender, EventArgs e)
        {
            //GridColumn column = sender as GridColumn;
            //column
            //if (column.Name == "StockId")
            //{

            //}
        }

        private void gridView2_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridView2_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gridView2.SetRowCellValue(e.RowHandle, colSpCTS, splLossCts.SummaryValue);
            gridView2.SetRowCellValue(e.RowHandle, colSpTotal, splLossTotal.SummaryValue);
            gridView2.SetRowCellValue(e.RowHandle, colSpCt, splLossCt.SummaryValue);

            gridView3.AddNewRow();
            gridView4.AddNewRow();
        }

        private void gridView3_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gridView3.SetRowCellValue(e.RowHandle, colOldCt, Convert.ToDouble(gridView2.GetRowCellValue(e.RowHandle, colSpCt)));
            gridView3.SetRowCellValue(e.RowHandle, colOldCts, Convert.ToDouble(gridView2.GetRowCellValue(e.RowHandle, colSpCTS)));
            gridView3.SetRowCellValue(e.RowHandle, colOldTotal, Convert.ToDouble(gridView2.GetRowCellValue(e.RowHandle, colSpTotal)));
        }

        private void gridView4_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gridView4.SetRowCellValue(e.RowHandle, colNewCt, Convert.ToDouble(gridView2.GetRowCellValue(e.RowHandle, colSpCt)) + Convert.ToDouble(gridView3.GetRowCellValue(e.RowHandle, colOldCt)));
            gridView4.SetRowCellValue(e.RowHandle, colNewCts, Convert.ToDouble(gridView2.GetRowCellValue(e.RowHandle, colSpCTS)) + Convert.ToDouble(gridView3.GetRowCellValue(e.RowHandle, colOldCts)));
            gridView4.SetRowCellValue(e.RowHandle, colNewTotal, Convert.ToDouble(gridView2.GetRowCellValue(e.RowHandle, colSpTotal)) + Convert.ToDouble(gridView3.GetRowCellValue(e.RowHandle, colOldTotal)));
        }
    }
}
