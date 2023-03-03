
using ConsoleApp9;
MyVector<int> myVector = new MyVector<int>();
myVector.WriteElement(1,0);
myVector.WriteElement(2, 1);
myVector.WriteElement(3, 2);
myVector.WriteElement(4, 3);
int c = myVector.ReadElement(2);
Console.WriteLine(c);