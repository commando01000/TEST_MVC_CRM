﻿using CRM.Repository;
using CRM.Repository.Product;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BusinessLayer.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductModel CreateProductAsync(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProductsAsync()
        {
            List<ProductModel> products = new List<ProductModel>();

            var AllProducts = _productRepository.GetAllProductsAsync();
            foreach (var product in AllProducts)
            {
                products.Add(new ProductModel
                {
                    Id = product.Id,
                    ProductName = product.GetAttributeValue<string>("initiumc_productname"),
                    CurrentStock = product.GetAttributeValue<int>("initiumc_currentstock"),
                });
            }

            return products;
        }

        public ProductModel GetProductByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
