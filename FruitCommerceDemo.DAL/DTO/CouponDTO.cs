using FruitCommerceDemo.Core.Interfaces.DTO;
using FruitCommerceDemo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FruitCommerceDemo.DAL.DTO
{
    public class CouponDTO : ICouponDTO
    {
        public CouponDTO(Coupon coupon)
        {
            CouponId = coupon.CouponId;
            Code = coupon.Code;
            DiscountPercent = coupon.DiscountPercent;
            AppliesToProductIds = coupon.AppliesToProductIds.Split(",").Select(o => Int32.Parse(o));
        }
        public int CouponId { get; set; }
        public string Code { get; set; }
        public decimal DiscountPercent { get; set; }
        public IEnumerable<int> AppliesToProductIds { get; set; }
    }
}
