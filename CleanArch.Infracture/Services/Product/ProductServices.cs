using CleanArch.App.DTO;
using CleanArch.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infracture.Services.Product
{
    public class ProductServices : IProductServices
    {
        private readonly PostgresContext _context;
        public ProductServices(PostgresContext context)
        {
            _context = context;
        }
        async Task<dynamic> IProductServices.GetAllProduct()
        {
            return await _context.Products.Select(x => new ProductDTO { ProductId = x.ProductId, ProductName = x.ProductName }).ToListAsync();
            //return null;
        }
    }
}
