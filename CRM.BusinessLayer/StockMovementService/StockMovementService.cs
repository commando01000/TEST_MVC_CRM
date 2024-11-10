using CRM.Repository;
using CRM.Repository.Models;
using CRM.Repository.StockMovementService;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BusinessLayer.StockMovementService
{
    public class StockMovementService : IStockMovementService
    {
        private readonly IStockMovementRepository _stockMovementRepository;
        private readonly IProductRepository _productRepository;


        public StockMovementService(IStockMovementRepository stockMovementRepository, IProductRepository productRepository)
        {
            _stockMovementRepository = stockMovementRepository;
            _productRepository = productRepository;
        }
        public void AddStockMovementAsync(StockMovement stockMovement)
        {
            throw new NotImplementedException();
        }

        public void DeleteStockMovementAsync(StockMovement stockMovement)
        {
            throw new NotImplementedException();
        }

        public List<StockMovement> GetAllStockMovementsAsync()
        {
            List<StockMovement> stockMovements = new List<StockMovement>();

            var myStockMovements = _stockMovementRepository.GetAll();

            foreach (var stockMovement in myStockMovements)
            {
                ProductModel product = new ProductModel
                {
                    Id = stockMovement.GetAttributeValue<Guid>("initiumc_relatedproduct"),
                    ProductName = stockMovement.GetAttributeValue<string>("initiumc_productname"),
                    CurrentStock = stockMovement.GetAttributeValue<int>("initiumc_currentstock")
                };

                stockMovements.Add(new StockMovement
                {
                    Id = stockMovement.GetAttributeValue<Guid>("initiumc_stockmovementid"),
                    MovementType = stockMovement.GetAttributeValue<int>("initiumc_movementtype"),
                    Quantity = stockMovement.GetAttributeValue<int>("initiumc_quantity"),
                    ProductId = stockMovement.GetAttributeValue<Guid>("initiumc_relatedproduct"),
                    Product = product,
                    Date = stockMovement.GetAttributeValue<DateTime>("initiumc_date"),
                });
            }

            return stockMovements;
        }

        public StockMovement GetStockMovementByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateStockMovementAsync(StockMovement stockMovement)
        {
            throw new NotImplementedException();
        }
    }
}
