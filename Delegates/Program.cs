using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegateTwo(string message);
    public delegate int MyDelegateInt(int numberOne, int numberTwo);


    class Program
    {//ExorTek(Mehmet Demirel)
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            //myDelegate -= customerManager.SendMessage;
            myDelegate();

            Console.WriteLine("-----------------------");

            MyDelegateTwo myDelegateTwo = customerManager.SendMessageTwo;
            myDelegateTwo += customerManager.ShowAlertTwo;
            myDelegateTwo("Hello");

            Console.WriteLine("-----------------------");

            MathClass mathClass = new MathClass();
            MyDelegateInt myDelegateInt = mathClass.Sum;
           // myDelegateInt += mathClass.Multiplication;
            var sum = myDelegateInt(5, 4);
            Console.WriteLine(sum);

            Console.ReadLine();
        }

        public class CustomerManager
        {
            public void SendMessage()
            {
                Console.WriteLine("Hello !");
            }
            public void ShowAlert()
            {
                Console.WriteLine("Warning !");
            }
            public void SendMessageTwo(string message)
            {
                Console.WriteLine(message);
            }
            public void ShowAlertTwo(string alert)
            {
                Console.WriteLine(alert);
            }
        }
        public class MathClass
        {
            public int Sum(int numberOne, int numberTwo)
            {
                return numberOne + numberTwo;
            }
            public int Multiplication(int numberOne, int numberTwo)
            {
                return numberOne * numberTwo;
            }
        }
    }
}
