using DockerCarvedRockApi.ApiModels;
using DockerCarvedRockApi.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerCarvedRockApi.Domain
{
    public class QuickOrderLogic : IQuickOrderLogic
    {
        private ILogger<QuickOrderLogic> _logger;

        public QuickOrderLogic(ILogger<QuickOrderLogic> logger)
        {
            _logger = logger;
        }
        public Guid PlaceQuickOrder(QuickOrder order, int CustomerId)
        {
            _logger.LogInformation("Placing order and returning order number ");
            return Guid.NewGuid();
        }
    }
}
