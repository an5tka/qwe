using ClassLibrary;
using System.Xml.Linq;

public class SweetsGiftPrinter
{
    public void Print(double TotW)
    {
        Console.WriteLine("Вес подарка с конфетами: " + TotW);
    }
}
public class SweetsGiftCalculator
{
    public double GetTotalWeight()
    {
        double totalWeight = 0;
        int i;
        for (i = 0; i < SweetsGift.Sweets.Count; i++)
        {
            totalWeight += SweetsGift.Sweets[i].Weight;
        }
        return totalWeight;
    }
}
class Program
{
    static void Main(string[] args)
    {
        SweetsGift sweetsGift = SweetsGiftFactory.CreateSweetsGift();
        SweetsGiftCalculator sweetsGiftCalculator = new SweetsGiftCalculator();
        double totalWeight = sweetsGiftCalculator.GetTotalWeight();
        SweetsGiftPrinter sweetsGiftPrinter = new SweetsGiftPrinter();
        sweetsGiftPrinter.Print(totalWeight);

    }
}
public class SweetsGiftFactory
{
    public static SweetsGift CreateSweetsGift()
    {
        CandiesSweets cn_sweets = new()
        {
            Name = "Баунти",
            Weight = 260,
            Type = "Сладкая",
            Calories = 494
        };
        ChocolatesSweets ch_sweets = new()
        {
            Name = "Милка",
            Weight = 190,
            Taste = "Вкусная",
            Brand = "Milka"
        };
        SweetsGift sweetsGift = new();
        sweetsGift.AddSweetS(cn_sweets);
        sweetsGift.AddSweetS(ch_sweets);

        return sweetsGift;
    }

}
