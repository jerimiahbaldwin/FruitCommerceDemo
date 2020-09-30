namespace FruitCommerceDemo.Core.Interfaces.DTO
{
    public interface IShoppingCartItemDTO
    {
        int ShoppingCartId { get; set; }
        IProductDTO Product { get; set; }
        int Quantity { get; set; }
    }
}
