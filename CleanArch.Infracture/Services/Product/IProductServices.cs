using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infracture.Services.Product
{
    public interface IProductServices
    {
        Task<dynamic> GetAllProduct();
    }
}
