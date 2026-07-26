using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Reports;
using StockManagementSystem.Models.ViewModels;
using StockManagementSystem.Services.ReportsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.ReportService
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository _reportRepository;

        public ReportService(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public async Task<List<PurchaseReportModel>> GetPurchaseReportAsync(DateTime fromDate, DateTime toDate)
        {
            return await _reportRepository.GetPurchaseReportAsync(fromDate, toDate);
        }

        public async Task<List<SalesReportModel>> GetSalesReportAsync(DateTime fromDate, DateTime toDate)
        {
            return await _reportRepository.GetSalesReportAsync(fromDate, toDate);
        }

        public async Task<List<StockReportModel>> GetStockReportAsync()
        {
            return await _reportRepository.GetStockReportAsync();

        }

        public async Task<ReportSummaryModel> GetReportSummaryAsync(
    string reportType,
    DateTime fromDate,
    DateTime toDate)
        {
            return await _reportRepository.GetReportSummaryAsync(
                reportType,
                fromDate,
                toDate);
        }



        public async Task<List<ChartDataModel>> GetCartesianChartDataAsync(
    string reportType,
    DateTime fromDate,
    DateTime toDate)
        {
            return await _reportRepository.GetCartesianChartDataAsync(
                reportType,
                fromDate,
                toDate);
        }

        public async Task<List<PieChartDataModel>> GetPieChartDataAsync(
            string reportType,
            DateTime fromDate,
            DateTime toDate)
        {
            return await _reportRepository.GetPieChartDataAsync(
                reportType,
                fromDate,
                toDate);
        }
    }
}
