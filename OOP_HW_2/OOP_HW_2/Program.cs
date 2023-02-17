using OOP_HW_2;

CreditCard card_1 = new CreditCard();
Console.WriteLine($"У вас на счету-{card_1.cash}");
card_1.Add_Money(300);
CreditCard card_2 = new CreditCard();
Console.WriteLine($"У вас на счету-{card_2.cash}");
card_2.Add_Money(500);
CreditCard card_3 = new CreditCard();
Console.WriteLine($"У вас на счету-{card_3.cash}");
card_3.Take_Cash(500);