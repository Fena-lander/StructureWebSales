﻿using WebSales.Data;
using WebSales.Models;

namespace WebSales.Services
{
    public class SellerService : ISellerService
    {
        private readonly WebSalesContext _context;

        public SellerService(WebSalesContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}