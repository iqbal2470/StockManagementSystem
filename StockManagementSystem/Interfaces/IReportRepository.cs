using StockManagementSystem.Models.Reports;
using StockManagementSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Interfaces
{
    public interface IReportRepository
    {
        Task<List<PurchaseReportModel>> GetPurchaseReportAsync(DateTime fromDate, DateTime toDate);

        Task<List<SalesReportModel>> GetSalesReportAsync(DateTime fromDate, DateTime toDate);

        Task<List<StockReportModel>> GetStockReportAsync();

        Task<ReportSummaryModel> GetReportSummaryAsync(
    string reportType,
    DateTime fromDate,
    DateTime toDate);

        Task<List<ChartDataModel>> GetCartesianChartDataAsync(
    string reportType,
    DateTime fromDate,
    DateTime toDate);

        Task<List<PieChartDataModel>> GetPieChartDataAsync(
            string reportType,
            DateTime fromDate,
            DateTime toDate);
    }


}
