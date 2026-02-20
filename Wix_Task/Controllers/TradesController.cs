using Microsoft.AspNetCore.Mvc;

namespace Wix_Task.Controllers
{
    [ApiController]
    [Route("api")]
    public class TradesController : ControllerBase
    {
        private readonly IProcessTradeService _processTradeService;

        public TradesController(IProcessTradeService processTradeService)
        {
            _processTradeService = processTradeService;
        }

        [HttpPost("BuyMakeTrade")]
        public double BuyMakeTrade(int amount, double price)
        {
            return _processTradeService.BuyMakeTrade(amount, price);
        }

        [HttpPost("BuyTakeTrade")]
        public double BuyTakeTrade(int amount, double price)
        {
            return _processTradeService.BuyTakeTrade(amount, price);
        }

        [HttpPost("SellMakeTrade")]
        public double SellMakeTrade(int amount, double price)
        {
            return _processTradeService.SellMakeTrade(amount, price);
        }

        [HttpPost("SellTakeTrade")]
        public double SellTakeTrade(int amount, double price)
        {
            return _processTradeService.SellTakeTrade(amount, price);
        }
    }
}
