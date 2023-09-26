using AutoMapper;
using BusinessObjects.Models;
using DataAccess.DAO;
using DataAccess.DTO;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class ProductRepository : IProductRepository
    {
        MyDbContext _context;
        IMapper mapper;
        ProductDAO productDAO;
        public ProductRepository(MyDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        public void CreateProduct(ProductDTO productDTO)
        {
            productDAO = new ProductDAO(_context);
            Product p = mapper.Map<Product>(productDTO);
            productDAO.CreateProduct(p);
        }

        public List<ProductDTO> GetProducts()
        {
            productDAO = new ProductDAO(_context);
            List<ProductDTO> productDTOs = mapper.Map<List<ProductDTO>>(productDAO.GetProducts());
            return productDTOs;
        }


        public ProductDTO GetProductById(int id)
        {
            productDAO = new ProductDAO(_context);
            ProductDTO productDTOs = mapper.Map<ProductDTO>(productDAO.GetProductById(id));
            return productDTOs;
        }
        public void UpdateProduct(ProductDTO productDTO)
        {
            productDAO = new ProductDAO(_context);
            Product p = mapper.Map<Product>(productDTO);
            productDAO.UpdateProduct(p);
        }
        public void DeleteProduct(int id)
        {
            productDAO = new ProductDAO(_context);
            productDAO.DeleteProduct(id);
        }

        public List<ProductDTO> GetProductsByName(string name)
        {
            productDAO = new ProductDAO(_context);
            List<ProductDTO> productDTOs = mapper.Map<List<ProductDTO>>(productDAO.GetProductsByName(name));
            return productDTOs;
        }

        public List<ProductDTO> GetProductsByPrice(decimal minPrice, decimal maxPrice)
        {
            productDAO = new ProductDAO(_context);
            List<ProductDTO> productDTOs = mapper.Map<List<ProductDTO>>(productDAO.GetProductsByPrice(minPrice, maxPrice));
            return productDTOs;
        }
    }
}
