public abstract class Trade
{
    public double Fee { get; set; }
    public int Amount { get; set; }
    public double Price { get; set; }

    public virtual double ApplyFee()
    {
        if(Amount <= 0)
        {
            return Amount;
        }

        return Amount * Price - (Fee * Amount * Price);
    }
}