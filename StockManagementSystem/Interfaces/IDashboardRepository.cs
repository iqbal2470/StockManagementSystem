using StockManagementSystem.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Interfaces
{

    public interface IDashboardRepository
    {
        Task<DashboardSummaryModel> GetDashboardSummaryAsync();

        Task<List<SalesChartModel>> GetSalesChartAsync();

        Task<List<StockChartModel>> GetStockChartAsync();

        Task<List<RecentSaleModel>> GetRecentSalesAsync();

        Task<List<TopSellingProductModel>> GetTopSellingProductsAsync();
    }
}
