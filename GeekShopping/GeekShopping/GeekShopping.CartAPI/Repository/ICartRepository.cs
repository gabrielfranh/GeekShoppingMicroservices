﻿using GeekShopping.CartAPI.Data.DTO;

namespace GeekShopping.CartAPI.Repository
{
    public interface ICartRepository
    {
        Task<CartDTO> FindCartByUserId(string userId);
        Task<CartDTO> SaveOrUpdateCart(CartDTO cartDTO);
        Task<bool> RemoveFromCart(long cartDetailsId);
        Task<bool> ApplyCoupon(string userId, string couponId);
        Task<bool> RemoveCoupon(string userId);
        Task<bool> ClearCart(string userId);
    }
}