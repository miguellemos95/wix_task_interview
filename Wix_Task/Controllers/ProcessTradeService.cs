public class ProcessTradeService : IProcessTradeService
{
    public double BuyPrice = 0;

    public double BuyMakeTrade(int amount, double price)
    {
        var trade = new MakeTrade(amount, price);
        BuyPrice = trade.ApplyFee();

        return BuyPrice;
    }

    public double BuyTakeTrade(int amount, double price)
    {
        var trade = new TakeTrade(amount, price);
        BuyPrice = trade.ApplyFee();
        
        return BuyPrice;
    }

    public double SellMakeTrade(int amount, double price)
    {
        var sellTrade = new MakeTrade(amount, price);
        
        return sellTrade.ApplyFee() - BuyPrice;
    }

    public double SellTakeTrade(int amount, double price)
    {
        var sellTrade = new TakeTrade(amount, price);

        return sellTrade.ApplyFee() - BuyPrice;
    }
}