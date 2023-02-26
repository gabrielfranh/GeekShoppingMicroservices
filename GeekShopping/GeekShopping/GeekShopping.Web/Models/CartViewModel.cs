namespace GeekShopping.Web.Models
{
    public class CartViewModel
    {
        public CartHeaderDTO CartHeader { get; set; }
        public IEnumerable<CartDetailDTO> CartDetails { get; set; }
    }
}
