using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DLL_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.Load("Lab2_Library");
            Object instance = assembly.CreateInstance("Class1");
            var type = assembly.GetType("Class1");
          

            Console.Write("Введите x: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y: ");
            double c = Convert.ToDouble(Console.ReadLine());

            var numbers = new object[2];
            numbers[0] = b;
            numbers[1] = c;


            if ((b * c) >= 0)
            {
                MethodInfo method = type.GetMethod("Add");

                Console.WriteLine(method.Invoke(instance, numbers));
            }
            else
            {
                MethodInfo meth = type.GetMethod("Sub");

                Console.WriteLine(meth.Invoke(instance, numbers));
            }



            Console.ReadLine();
        }
    }
}
