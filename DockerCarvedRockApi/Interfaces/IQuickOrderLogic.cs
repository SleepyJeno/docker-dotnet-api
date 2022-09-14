using DockerCarvedRockApi.ApiModels;

namespace DockerCarvedRockApi.Interfaces
{
    public  interface IQuickOrderLogic
    {
        public Guid PlaceQuickOrder(QuickOrder order, int customerId);
    }
}