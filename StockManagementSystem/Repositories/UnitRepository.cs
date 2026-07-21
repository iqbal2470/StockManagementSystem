using StockManagementSystem.Data;
using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Repositories
{

    public class UnitRepository : GenericRepository<Unit>, IUnitRepository
    {
        public UnitRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
