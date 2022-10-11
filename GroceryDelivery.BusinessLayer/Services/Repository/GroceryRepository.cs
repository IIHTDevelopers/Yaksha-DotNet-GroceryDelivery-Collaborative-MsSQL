using GroceryDelivery.DataLayer;
using GroceryDelivery.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryDelivery.BusinessLayer.Services.Repository
{
    public class GroceryRepository : IGroceryRepository
    {
        /// <summary>
        /// Creating Referance variable of GroceryDbContext
        /// Injecting in GroceryRepository constructor
        /// </summary>
        private readonly GroceryDbContext _groceryContext;

        public GroceryRepository(GroceryDbContext groceryDbContext)
        {
            _groceryContext = groceryDbContext;
        }
        /// <summary>
        /// Add new product in InMemoryDb
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Product> AddProduct(Product product)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get All product and product by id also
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> GetAllProduct(int ?id)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get product by Id
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public async Task<Product> GetProductById(int ProductId)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Menu List of catogery
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Menubar>> MenuList()
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Place order
        /// </summary>
        /// <param name="ProductId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> PlaceOrder(int ProductId, ApplicationUser user)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Find Product by Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> ProductByName(string name)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Order Information of ordered product
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ProductOrder>> OrderByuserId(int UserId)
        {
            //do code here
            throw new NotImplementedException();
        }
    }
}
