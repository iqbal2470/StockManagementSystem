using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Reports;
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
    }
}
