using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //FourOperations fourOperations = new FourOperations(5, 4);
            //Console.WriteLine(fourOperations.Sum(1, 7));
            //Console.WriteLine(fourOperations.Division());
            

            var type = typeof(FourOperations);

            //FourOperations fourOperations = (FourOperations)Activator.CreateInstance(type,6,3);
            //Console.WriteLine(fourOperations.Sum(4, 5));
            //Console.WriteLine(fourOperations.Division());

            //var instance = Activator.CreateInstance(type, 6, 3);
            //Console.WriteLine(instance.GetType().GetMethod("Division").Invoke(instance, null));

            var methods = type.GetMethods();

            foreach (var info in methods)
            {
                Console.WriteLine("Method Name : "+info.Name);
                
                foreach (var parameterInfo in info.GetParameters())
                {
                    
                    Console.WriteLine("Parameter Name : "+parameterInfo.Name);
                }
                
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : "+attribute.GetType());
                }
                Console.WriteLine("------------------");
            }

            Console.ReadLine();

        }
    }

    class FourOperations
    {
        private int _numberOne, _numberTwo;

        public FourOperations(int numberOne, int numberTwo)
        {
            _numberOne = numberOne;
            _numberTwo = numberTwo;
        }
        public int Sum(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
        public int Multiplication(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }
        [MethodName("Division")]
        public int Division()
        {
            return _numberOne / _numberTwo;
        }
        public int Subtraction()
        {
            return _numberOne - _numberTwo;
        }

    }

    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {
            
        }
    }
}
