using AutoMapper;
using GeekShopping.ProductAPI.DTO;
using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Model.Context;
using GeekShopping.ProductAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public ProductRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductDTO> Create(ProductDTO product)
        {
            Product createdProduct = _mapper.Map<Product>(product);
            await _context.Products.AddAsync(createdProduct);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductDTO>(createdProduct);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Product product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync() ?? new Product();
                
                if(product.Id <= 0)
                    return false;
                else
                {
                    _context.Products.Remove(product);
                    await _context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<IEnumerable<ProductDTO>> GetAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductDTO>>(products);
        }

        public async Task<ProductDTO> GetById(int id)
        {
            Product product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync() ?? new Product();
            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<ProductDTO> Update(ProductDTO product)
        {
            Product createdProduct = _mapper.Map<Product>(product);
            _context.Products.Update(createdProduct);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductDTO>(createdProduct);
        }
    }
}
