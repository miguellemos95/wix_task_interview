public class MakeTrade : Trade
{
    public MakeTrade(int amount, double price)
    {
        Amount = amount;
        Price = price;
    }

    public override double ApplyFee()
    {
        Fee = 0.001;
        
        return base.ApplyFee();
    }
}