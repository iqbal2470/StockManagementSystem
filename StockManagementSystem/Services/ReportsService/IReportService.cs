using StockManagementSystem.Models.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.ReportsService
{
    public interface IReportService
    {
        Task<List<PurchaseReportModel>> GetPurchaseReportAsync(DateTime fromDate, DateTime toDate);

        Task<List<SalesReportModel>> GetSalesReportAsync(DateTime fromDate, DateTime toDate);

        Task<List<StockReportModel>> GetStockReportAsync();
    }
}
