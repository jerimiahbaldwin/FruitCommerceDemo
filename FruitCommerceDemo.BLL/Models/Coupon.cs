using FruitCommerceDemo.Core.Interfaces.DTO;
using System.Collections.Generic;

namespace FruitCommerceDemo.BLL.Models
{
    public class Coupon
    {
        private ICouponDTO _dto;
        private Coupon() { } // hide the constructor
        public Coupon(ICouponDTO dto)
        {
            _dto = dto;
        }
        public string Code { get { return _dto.Code; } set { _dto.Code = value; } }
        public decimal DiscountPercent { get { return _dto.DiscountPercent; } set { _dto.DiscountPercent = value; } }
        public IEnumerable<int> AppliesToProductIds { get { return _dto.AppliesToProductIds; } set { _dto.AppliesToProductIds = value; } }
    }
}
