public class TakeTrade : Trade
{
    public TakeTrade(int amount, double price)
    {
        Amount = amount;
        Price = price;
    }

    public override double ApplyFee()
    {
        Fee = 0.005;

        return base.ApplyFee();
    }
}