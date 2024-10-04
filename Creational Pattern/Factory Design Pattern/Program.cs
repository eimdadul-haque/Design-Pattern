public interface ICreditCard
{
    string GetCardType();
    int GetCreditLimit();
    int GetAnnualCharge();
}

public class PlatinumCreditCard : ICreditCard
{
    public int GetAnnualCharge() => 1500;
    public string GetCardType() => "Platinum";
    public int GetCreditLimit() => 15000;
}

public class GoldCreditCard : ICreditCard
{
    public int GetAnnualCharge() => 1000;
    public string GetCardType() => "Gold";
    public int GetCreditLimit() => 10000;
}

public class SilverCreditCard : ICreditCard
{
    public int GetAnnualCharge() => 500;
    public string GetCardType() => "Silver";
    public int GetCreditLimit() => 5000;
}

public abstract class CreditCardFactory
{
    public abstract ICreditCard MakeCreditCard();

    public ICreditCard GetCard() => MakeCreditCard();
}

public class PlatinumCard : CreditCardFactory
{
    public override ICreditCard MakeCreditCard()
    {
        return new PlatinumCreditCard();
    }
}

public class GoldCard : CreditCardFactory
{
    public override ICreditCard MakeCreditCard()
    {
        return new GoldCreditCard();
    }
}

public class SilverCard : CreditCardFactory
{
    public override ICreditCard MakeCreditCard()
    {
        return new SilverCreditCard();
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        CreditCardFactory factory = null;

        int type = 1;
        switch (type)
        {
            case 1:
                factory = new PlatinumCard();
                break;
            case 2:
                factory = new GoldCard();
                break;
            case 3:
                factory = new SilverCard();
                break;
            default:
                Console.WriteLine("Out of type.");
                break;
        }

        ICreditCard card = factory.GetCard();
        Console.WriteLine($"{card.GetCreditLimit()} {card.GetCardType()} {card.GetAnnualCharge()}");
    }
}

