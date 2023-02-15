using System;


namespace OOP_HW
{
    public class PhoneClass
    {
        public string number;
        public double weight;
        public string model;
        

        public PhoneClass(string numberInit, double weightInit, string modelInit)
        {
            number = numberInit;
            weight = weightInit;
            model = modelInit;
        }
        public void RecieveCall(string name,out string res)
        {
             res = string.Format($"Звонит-{name}");
        }
        public int GetNumberOfRecieveCall(int numberOfperson)
        {
            return numberOfperson;
        }


    }
    
}

