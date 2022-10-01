using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<ProductDetailDto> GetProductDetails();
    }
}
