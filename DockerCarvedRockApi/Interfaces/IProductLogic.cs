using DockerCarvedRockApi.ApiModels;

namespace DockerCarvedRockApi.Interfaces
{
    public interface IProductLogic
    {
        IEnumerable<Product> GetProductsForCategory(string category);
    }
}