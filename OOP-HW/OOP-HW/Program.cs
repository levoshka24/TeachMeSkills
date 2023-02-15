using OOP_HW;

PhoneClass phone1 = new PhoneClass("+375441295746",6.5,"iphone");
PhoneClass phone2 = new PhoneClass("+375295968576",7.4,"samsung");
PhoneClass phone3 = new PhoneClass("+375336859634",6.5,"huawei");
phone1.RecieveCall("Petya",out string name1);
phone2.RecieveCall("Viktor",out string name2);
phone3.RecieveCall("Alexey",out string name3);
int ph1 = phone1.GetNumberOfRecieveCall(3754438);
int ph2 = phone1.GetNumberOfRecieveCall(3754438);
int ph3 = phone1.GetNumberOfRecieveCall(3754438);
Console.WriteLine(name1 + " " + ph1);
Console.WriteLine(name2 + " " + ph2);
Console.WriteLine(name3 + " " + ph3);

