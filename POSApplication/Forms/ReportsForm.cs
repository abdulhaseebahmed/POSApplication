using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSApplication.Model;
using POSApplication.Model.POSClasses;
using POSApplication.Model.POSClasses.EntityClasses;
using Microsoft.Reporting.WinForms;
using System.Data.Entity;


namespace POSApplication.Forms
{
    public partial class ReportsForm : Form
    {
        public string reportType = "";
        public string categoryname = "";
        public string productname = "";

        public ReportsForm()
        {
            InitializeComponent();
        }

        public void child_onDateSelect(object sender, EventArgs e)
        {
            dateTimePicker1.Value = AppConfig.ReportCriteria_FromDate;
            dateTimePicker2.Value = AppConfig.ReportCriteria_ToDate;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'posdbDataSet.salesorders' table. You can move, or remove it, as needed.
            this.salesordersTableAdapter.Fill(this.posdbDataSet.salesorders);
            //this.reportViewer1.RefreshReport();
            loadCategories();
            loadProducts();
        }

        public void loadReport(String reportname)
        {
            switch (reportname)
            {
                case "SalesReport":
                    salesReport();
                    break;
                case "SalesReportHourly":
                    salesReportHourly();
                    break;
                case "SalesReportDaily":
                    salesReportDaily();
                    break;
                case "SalesReportMonthly":
                    salesReportMonthly();
                    break;
                case "SalesReportYearly":
                    salesReportYearly();
                    break;
                case "PurchasesReport":
                    PurchasesReport();
                    break;
                case "PurchasesReportHourly":
                    PurchasesReportHourly();
                    break;
                case "PurchasesReportDaily":
                    purchasesReportDaily();
                    break;
                case "PurchasesReportMonthly":
                    purchasesReportMonthly();
                    break;
                case "PurchasesReportYearly":
                    purchasesReportYearly();
                    break;
                default:
                    break;
            }
        }

        public void PurchasesReport()
        {
            using (var db = new posdbEntities())
            {
                var query = (from c in db.purchasesorders
                             select new { OrderID = c.OrderID, PurchaseAmount = c.PurchaseAmount, PurchaseStatus = c.PurchaseStatus, PurchaseDate = c.PurchaseDate, PurchaseTime = c.PurchaseTime }).ToList();
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("PurchasesDataSet", query.ToList());
                reportViewer1.LocalReport.ReportPath = @"../../Reports/Purchases_Reports/PurchasesReport.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.LocalReport.EnableExternalImages = true;

                string imagePath = @"file:///" + AppConfig.imagefile;
                ReportParameter parameter = new ReportParameter("ImagePathParameter", imagePath);
                reportViewer1.LocalReport.SetParameters(parameter);

                reportViewer1.RefreshReport();
            }
        }

        public void PurchasesReportHourly()
        {
            using (var db = new posdbEntities())
            {
                var query = (from c in db.purchasesorders
                             group c by c.time_hour into g
                             select new { PurchaseDate = g.Key, PurchaseAmount = g.Sum(p => p.PurchaseAmount) }).ToList();
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("PurchasesDataSet", query.ToList());
                reportViewer1.LocalReport.ReportPath = @"../../Reports/Purchases_Reports/PurchasesReportHourly.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.LocalReport.EnableExternalImages = true;

                string imagePath = @"file:///" + AppConfig.imagefile;
                ReportParameter parameter = new ReportParameter("ImagePathParameter", imagePath);
                reportViewer1.LocalReport.SetParameters(parameter);

                reportViewer1.RefreshReport();
            }
        }

        public void purchasesReportDaily()
        {
            using (var db = new posdbEntities())
            {
                var query = (from c in db.purchasesorders
                             group c by c.Date_DayofWeek_string into g
                             select new { PurchaseDate = g.Key, PurchaseAmount = g.Sum(p => p.PurchaseAmount) }).ToList();
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("PurchasesDataSet", query.ToList());
                reportViewer1.LocalReport.ReportPath = @"../../Reports/Purchases_Reports/PurchasesReportDaily.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.LocalReport.EnableExternalImages = true;

                string imagePath = @"file:///" + AppConfig.imagefile;
                ReportParameter parameter = new ReportParameter("ImagePathParameter", imagePath);
                reportViewer1.LocalReport.SetParameters(parameter);

                reportViewer1.RefreshReport();
            }
        }

        public void purchasesReportYearly()
        {
            using (var db = new posdbEntities())
            {
                var query = (from c in db.purchasesorders
                             group c by c.date_year_int into g
                             select new { PurchaseDate = g.Key, PurchaseAmount = g.Sum(p => p.PurchaseAmount) }).ToList();
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("PurchasesDataSet", query.ToList());
                reportViewer1.LocalReport.ReportPath = @"../../Reports/Purchases_Reports/PurchasesReportYearly.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.LocalReport.EnableExternalImages = true;

                string imagePath = @"file:///" + AppConfig.imagefile;
                ReportParameter parameter = new ReportParameter("ImagePathParameter", imagePath);
                reportViewer1.LocalReport.SetParameters(parameter);

                reportViewer1.RefreshReport();
            }
        }

        public void purchasesReportMonthly()
        {
            using (var db = new posdbEntities())
            {
                var query = (from c in db.purchasesorders
                             group c by c.date_month_string into g
                             select new { PurchaseDate = g.Key, PurchaseAmount = g.Sum(p => p.PurchaseAmount) }).ToList();
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("PurchasesDataSet", query.ToList());
                reportViewer1.LocalReport.ReportPath = @"../../Reports/Purchases_Reports/PurchasesReportMonthly.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.LocalReport.EnableExternalImages = true;

                string imagePath = @"file:///" + AppConfig.imagefile;
                ReportParameter parameter = new ReportParameter("ImagePathParameter", imagePath);
                reportViewer1.LocalReport.SetParameters(parameter);

                reportViewer1.RefreshReport();
            }
        }

        public void salesReport()
        {
            DateCriteriaForm rf = new DateCriteriaForm();
            rf.onSuccessfulDateSelect += new EventHandler(child_onDateSelect);
            rf.ShowDialog();

            using (var db = new posdbEntities())
            {
                var query = (from c in db.salesorders
                             where c.SaleDate >= AppConfig.ReportCriteria_FromDate && c.SaleDate <= AppConfig.ReportCriteria_ToDate
                             select new { OrderID = c.OrderID, SaleAmount = c.SaleAmount, SaleStatus = c.SaleStatus, SaleDate = c.SaleDate, SaleTime = c.SaleTime }).ToList();
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("SalesDataSet", query.ToList());
                reportViewer1.LocalReport.ReportPath = @"../../Reports/Sales_Reports/SalesReport.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.LocalReport.EnableExternalImages = true;

                string imagePath = @"file:///" + AppConfig.imagefile;
                ReportParameter parameter = new ReportParameter("ImagePathParameter", imagePath);
                reportViewer1.LocalReport.SetParameters(parameter);

                reportViewer1.RefreshReport();
            }
        }

        public void salesReportHourly()
        {

            DateCriteriaForm rf = new DateCriteriaForm();
            rf.onSuccessfulDateSelect += new EventHandler(child_onDateSelect);
            rf.ShowDialog();

            using (var db = new posdbEntities())
            {
                var query = (from c in db.salesorders
                             where c.SaleDate >= AppConfig.ReportCriteria_FromDate && c.SaleDate <= AppConfig.ReportCriteria_ToDate
                             group c by c.time_hour into g
                             select new { SaleDate = g.Key, SaleAmount = g.Sum(p => p.SaleAmount) }).ToList();
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("SalesDataSet", query.ToList());
                reportViewer1.LocalReport.ReportPath = @"../../Reports/Sales_Reports/SalesReportHourly.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.LocalReport.EnableExternalImages = true;

                string imagePath = @"file:///" + AppConfig.imagefile;
                ReportParameter parameter = new ReportParameter("ImagePathParameter", imagePath);
                reportViewer1.LocalReport.SetParameters(parameter);

                reportViewer1.RefreshReport();
            }
        }

        public void salesReportDaily()
        {
            DateCriteriaForm rf = new DateCriteriaForm();
            rf.onSuccessfulDateSelect += new EventHandler(child_onDateSelect);
            rf.ShowDialog();

            using (var db = new posdbEntities())
            {
                var query = (from c in db.salesorders
                             where c.SaleDate >= AppConfig.ReportCriteria_FromDate && c.SaleDate <= AppConfig.ReportCriteria_ToDate
                             group c by c.Date_DayofWeek_string into g
                             select new { SaleDate = g.Key, SaleAmount = g.Sum(p => p.SaleAmount) }).ToList();
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("SalesDataSet", query.ToList());
                reportViewer1.LocalReport.ReportPath = @"../../Reports/Sales_Reports/SalesReportDaily.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.LocalReport.EnableExternalImages = true;

                string imagePath = @"file:///" + AppConfig.imagefile;
                ReportParameter parameter = new ReportParameter("ImagePathParameter", imagePath);
                reportViewer1.LocalReport.SetParameters(parameter);

                reportViewer1.RefreshReport();
            }
        }

        public void salesReportYearly()
        {
            DateCriteriaForm rf = new DateCriteriaForm();
            rf.onSuccessfulDateSelect += new EventHandler(child_onDateSelect);
            rf.ShowDialog();

            using (var db = new posdbEntities())
            {
                var query = (from c in db.salesorders
                             where c.SaleDate >= AppConfig.ReportCriteria_FromDate && c.SaleDate <= AppConfig.ReportCriteria_ToDate
                             group c by c.date_year_int into g
                             select new { SaleDate = g.Key, SaleAmount = g.Sum(p => p.SaleAmount) }).ToList();
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("SalesDataSet", query.ToList());
                reportViewer1.LocalReport.ReportPath = @"../../Reports/Sales_Reports/SalesReportYearly.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.LocalReport.EnableExternalImages = true;

                string imagePath = @"file:///" + AppConfig.imagefile;
                ReportParameter parameter = new ReportParameter("ImagePathParameter", imagePath);
                reportViewer1.LocalReport.SetParameters(parameter);

                reportViewer1.RefreshReport();
            }
        }

        public void salesReportMonthly()
        {
            DateCriteriaForm rf = new DateCriteriaForm();
            rf.onSuccessfulDateSelect += new EventHandler(child_onDateSelect);
            rf.ShowDialog();

            using (var db = new posdbEntities())
            {
                var query = (from c in db.salesorders
                             where c.SaleDate >= AppConfig.ReportCriteria_FromDate && c.SaleDate <= AppConfig.ReportCriteria_ToDate
                             group c by c.date_month_string into g
                             select new { SaleDate = g.Key, SaleAmount = g.Sum(p => p.SaleAmount) }).ToList();
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("SalesDataSet", query.ToList());
                reportViewer1.LocalReport.ReportPath = @"../../Reports/Sales_Reports/SalesReportMonthly.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.LocalReport.EnableExternalImages = true;

                string imagePath = @"file:///" + AppConfig.imagefile;
                ReportParameter parameter = new ReportParameter("ImagePathParameter", imagePath);
                reportViewer1.LocalReport.SetParameters(parameter);

                reportViewer1.RefreshReport();
            }
        }

        public void MostSellableItemsReport()
        {
            DateCriteriaForm rf = new DateCriteriaForm();
            rf.onSuccessfulDateSelect += new EventHandler(child_onDateSelect);
            rf.ShowDialog();

            using (var db = new posdbEntities())
            {
                var query = (from c in db.salesorderdetails
                             join d in db.salesorders on
                             c.OrderID equals d.OrderID
                             join p in db.products on
                             c.ProductID equals p.ProductID
                             join cat in db.categories on
                             p.CategoryID equals cat.CategoryID
                             where d.SaleDate >= AppConfig.ReportCriteria_FromDate && d.SaleDate <= AppConfig.ReportCriteria_ToDate
                             select new
                             {
                                 OrderID = c.OrderID,
                                 CategoryID = p.CategoryID,
                                 CategoryName = cat.CategoryName,
                                 ProductName = p.ProductName,
                                 SaleQuantity = c.Quantity,
                                 SaleAmount = c.SalePrice
                             }).ToList();

                var query2 = (from a in query
                              group a by new
                              {
                                  a.CategoryName,
                                  a.ProductName
                              } into g
                              select new { CategoryName = g.Key.CategoryName, ProductName = g.Key.ProductName, TotalQuantitySold = g.Sum(p => p.SaleQuantity), SaleAmount = g.Sum(p => p.SaleAmount) }
                             ).ToList();

                var resultList = query2.OrderByDescending(i => i.SaleAmount).Take(5);

                DataSet ds = new DataSet("MostSellableItemsDataSet");
                DataTable dt = new DataTable("MostSellableItemsTable");
                dt.Columns.Add("CategoryName");
                dt.Columns.Add("ProductName");
                dt.Columns.Add("TotalQuantitySold");
                dt.Columns.Add("SaleAmount");
                ds.Tables.Add(dt);

                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("MostSellableItemsDataSet", resultList);
                reportViewer1.LocalReport.ReportPath = @"../../Reports/Sales_Reports/MostSellableItemsReport.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.LocalReport.EnableExternalImages = true;

                string imagePath = @"file:///" + AppConfig.imagefile;
                ReportParameter parameter = new ReportParameter("ImagePathParameter", imagePath);
                reportViewer1.LocalReport.SetParameters(parameter);

                reportViewer1.RefreshReport();
            }
        }

        public void loadCategories()
        {
            using (var db = new Model.posdbEntities())
            {
                var query = (from c in db.categories
                             select new { CategoryName = c.CategoryName }).ToList();
            }
        }

        public void loadProducts()
        {
            using (var db = new Model.posdbEntities())
            {
                var query = (from p in db.products
                             select new { ProductName = p.ProductName }).ToList();
            }
        }

        public void loadSalesReport()
        {
            //using (var db = new Model.posdbEntities())
            //{
            //    var query = (from p in db.salesorders
            //                 group p by KeyDown 
            //                 select new { OrderID = g.Sum(g., Date = p.SaleDate, TotalSale =  }).ToList();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reportType = "SalesReport";
            loadReport(reportType);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reportType = "PurchasesReport";
            loadReport(reportType);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reportType = "SuppliersReport";
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reportType = "CustomerReport";
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reportType = "SalesbyProduct";
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reportType = "SalesMonthwiseReport";
        }

        private void SalesReportLabel_Click(object sender, EventArgs e)
        {
            loadReport("SalesReport");
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reportType = "PurchasesReportHourly";
            loadReport(reportType);
        }

        private void linkLabel14_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reportType = "PurchasesReportDaily";
            loadReport(reportType);
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reportType = "PurchasesReportMonthly";
            loadReport(reportType);
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reportType = "PurchasesReportYearly";
            loadReport(reportType);
        }

        private void SalesReportLabel_MouseClick(object sender, MouseEventArgs e)
        {
            reportType = "SalesReport";
            loadReport(reportType);
        }

        private void linkLabel2_MouseClick(object sender, MouseEventArgs e)
        {
            reportType = "SalesReportHourly";
            loadReport(reportType);
        }

        private void SalesDailyReportLabel_MouseClick(object sender, MouseEventArgs e)
        {
            reportType = "SalesReportDaily";
            loadReport(reportType);
        }

        private void linkLabel10_MouseClick(object sender, MouseEventArgs e)
        {
            reportType = "SalesReportMonthly";
            loadReport(reportType);
        }

        private void linkLabel11_MouseClick(object sender, MouseEventArgs e)
        {
            reportType = "SalesReportYearly";
            loadReport(reportType);
        }

        private void linkLabel16_MouseClick(object sender, MouseEventArgs e)
        {
            MostSellableItemsReport();
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void SaleByProductsLabel_MouseClick(object sender, MouseEventArgs e)
        {
            reportType = "SalesByProducts";
            loadReport(reportType);
        }
    }
}