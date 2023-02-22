using OOP_HW_2_TASK_2;

Phone phone_1 = new Phone(6.5,"iphone",5005040);
//phone_1.number = 949495954;
//phone_1.model = "iphone";
//phone_1.weight = 6.5;
Console.WriteLine($"1 телефон: Номер - {phone_1.number}, Вес - {phone_1.weight}, Модель - {phone_1.model}");
phone_1.RecieveCall("petya",550494);
Phone phone_2 = new Phone(5.6,"samsung",50403004);
//phone_2.number = 44030340;
//phone_2.model = "samsung";
//phone_2.weight = 5.6;
Console.WriteLine($"2 телефон: Номер - {phone_2.number}, Вес - {phone_2.weight}, Модель - {phone_2.model}");
phone_2.RecieveCall("vasya");
phone_2.GetNumber(59595959);
phone_2.SendMessage(39493, 3049, 49583);
Phone phone_3 = new Phone(5049595,"huawei");
//phone_3.number = 594309005;
//phone_3.model = "huawei";
//phone_3.weight = 5.7;
Console.WriteLine($"3 телефон: Номер - {phone_3.number},  Модель - {phone_3.model}");
phone_3.RecieveCall("nikita");
phone_3.GetNumber(100203020);
Phone phone_4 = new Phone();
phone_4.number = 44030340;
phone_4.model = "samsung";
phone_4.weight = 5.6;

