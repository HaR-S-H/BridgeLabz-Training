using System;

class CourseFeeDiscount
{
    static void Main()
    {  //define fee and discount percent
        double fee = 125000;

        double discountPercent = 10;

        //calculate discount and final fee
        double discount = (fee * discountPercent) / 100;
        
        double finalFee = fee - discount;
        //print discount and final fee
        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {finalFee}");
    }
}
