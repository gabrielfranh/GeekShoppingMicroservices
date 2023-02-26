using GeekShopping.CartAPI.Data.DTO;
using GeekShopping.CartAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.CartAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartRepository _cartRepository;

        public CartController(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        [HttpGet("find-cart/{id}")]
        public async Task<ActionResult<CartDTO>> FindById(string userId)
        {
            var cart = await _cartRepository.FindCartByUserId(userId);

            if (cart == null) 
                return NotFound();

            return Ok(cart);
        }

        [HttpPost("add-cart")]
        public async Task<ActionResult<CartDTO>> AddCart(CartDTO cartDTO)
        {
            var cart = await _cartRepository.SaveOrUpdateCart(cartDTO);

            if (cart == null)
                return NotFound();

            return Ok(cart);
        }

        [HttpPut("update-cart")]
        public async Task<ActionResult<CartDTO>> UpdateCart(CartDTO cartDTO)
        {
            var cart = await _cartRepository.SaveOrUpdateCart(cartDTO);

            if (cart == null)
                return NotFound();

            return Ok(cart);
        }

        [HttpDelete("remove-cart/{id}")]
        public async Task<ActionResult<CartDTO>> UpdateCart(int cartId)
        {
            var status = await _cartRepository.RemoveFromCart(cartId);

            if (status)
                return BadRequest();

            return Ok(status);
        }
    }
}
