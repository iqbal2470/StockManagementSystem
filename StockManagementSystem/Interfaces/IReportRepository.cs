using StockManagementSystem.Models.Reports;
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
    }
}
