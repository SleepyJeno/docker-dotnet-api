using DockerCarvedRockApi.ApiModels;
using DockerCarvedRockApi.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerCarvedRockApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class QuickOrderController : ControllerBase
    {
        private readonly ILogger<QuickOrderController> _logger;
        private readonly IQuickOrderLogic _orderLogic;

        public QuickOrderController(ILogger<QuickOrderController> logger, IQuickOrderLogic orderLogic)
        {
            _logger = logger;
            _orderLogic = orderLogic;
        }

        [HttpPost]
        public Guid SubmitQuickOrder(QuickOrder orderInfo)
        {
            _logger.LogInformation($"Submitting Order for {orderInfo.Quantity} of {orderInfo.ProductId}.");
            return _orderLogic.PlaceQuickOrder(orderInfo, 1234);
        }
    }
}
