public interface IProcessTradeService
{
    double BuyMakeTrade(int amount, double price);
    double BuyTakeTrade(int amount, double price);
    double SellMakeTrade(int amount, double price);
    double SellTakeTrade(int amount, double price);
}
