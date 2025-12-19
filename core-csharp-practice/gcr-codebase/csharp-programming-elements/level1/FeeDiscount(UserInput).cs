using System;

class FeeDiscountUserInput
{
    static void Main()
    {
        Console.Write("Enter fee amount: ");
        double fee = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        double discount = (fee * discountPercent) / 100;
        double finalFee = fee - discount;

        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {finalFee}");
    }
}
