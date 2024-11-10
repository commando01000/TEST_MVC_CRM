using CRM.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BusinessLayer.StockMovementService
{
    public interface IStockMovementService
    {
        List<StockMovement> GetAllStockMovementsAsync();
        StockMovement GetStockMovementByIdAsync(Guid id);
        void AddStockMovementAsync(StockMovement stockMovement);
        void UpdateStockMovementAsync(StockMovement stockMovement);
        void DeleteStockMovementAsync(StockMovement stockMovement);
    }
}
