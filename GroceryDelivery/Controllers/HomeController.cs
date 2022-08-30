using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroceryDelivery.BusinessLayer.Interfaces;
using GroceryDelivery.Entites;
using GroceryDelivery.BusinessLayer.ViewModels;

namespace Grocerydelivery.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// Creating Referance variable of IGroceryServices
        /// </summary>
        private readonly IGroceryServices _groceryServices;
        /// <summary>
        /// Injecting the IGroceryServices in controller constructor
        /// </summary>
        /// <param name="groceryServices"></param>
        public HomeController(IGroceryServices groceryServices)
        {
            _groceryServices = groceryServices;
        }


        /// <summary>
        /// Show all products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("get-all-products")]
        public async Task<IActionResult> AllProducts()
        {
            //do code here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Show list of categories
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("list-all-categories")]
        public async Task<IActionResult> AllCategory()
        {
            //do code here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Show the product Details by product id
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("product-details")]
        public async Task<IActionResult> Details(int ProductId)
        {
            //do code here
            throw new NotImplementedException();
        }

        
        /// <summary>
        /// Place order by product id
        /// </summary>
        /// <param name="ProductId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("place-order")]
        public async Task<IActionResult> Placeorder(int ProductId, ApplicationUser user)
        {
            //do code here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Used for show order info
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("order-info")]
        public async Task<IActionResult> OrderInfo(int userId)
        {
            //do code here
            throw new NotImplementedException();
        }
    }
}
