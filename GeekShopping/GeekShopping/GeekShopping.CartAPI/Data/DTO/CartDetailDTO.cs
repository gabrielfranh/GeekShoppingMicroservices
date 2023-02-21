﻿using GeekShopping.CartAPI.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CartAPI.Data.DTO
{
    public class CartDetailDTO
    {
        public long Id { get; set; }

        public long CarteaderId { get; set; }

        public CartHeaderDTO CartHeader { get; set; }

        public long ProductId { get; set; }

        public ProductDTO Product { get; set; }

        public int Count { get; set; }
    }
}
