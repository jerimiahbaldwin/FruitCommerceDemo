namespace FruitCommerceDemo.Core.Interfaces.DTO
{
    public interface IProductDTO
    {
        int ProductId { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string ImageUrl { get; set; }
        decimal Price { get; set; }
    }
}
