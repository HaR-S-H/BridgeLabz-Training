using System;

class FeeDiscountUserInput
{
    static void Main()
    {  //take fee and discount percent as input from user
        Console.Write("enter fee");

        double fee = Convert.ToDouble(Console.ReadLine());

        Console.Write("enter discount percentage");

        double discountPercent = Convert.ToDouble(Console.ReadLine());
        //calculate discount and final fee
        double discount = (fee * discountPercent) / 100;
        double finalFee = fee - discount;
        //print discount and final fee
        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {finalFee}");
    }
}
