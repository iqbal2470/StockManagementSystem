using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.Dashboard
{
    public class DashboardService : IDashboardService
    {
        private readonly IDashboardRepository _repository;

        public DashboardService(IDashboardRepository repository)
        {
            _repository = repository;
        }

        public Task<DashboardSummaryModel> GetDashboardSummaryAsync()
        {
            return _repository.GetDashboardSummaryAsync();
        }



        //public Task<List<SalesChartModel>> GetSalesChartAsync()
        //{
        //    return _repository.GetSalesChartAsync();
        //}

        public Task<List<SalesChartModel>> GetSalesChartAsync(string dt)
        {
            return _repository.GetSalesChartAsync(dt);
        }

        public Task<List<StockChartModel>> GetStockChartAsync()
        {
            return _repository.GetStockChartAsync();
        }

        public Task<List<RecentSaleModel>> GetRecentSalesAsync()
        {
            return _repository.GetRecentSalesAsync();
        }

        public Task<List<TopSellingProductModel>> GetTopSellingProductsAsync(string duration)
        {
            return _repository.GetTopSellingProductsAsync(duration);
        }
    }
}
