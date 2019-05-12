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
            MethodInfo method = type.GetMethod("Add");

            Console.Write("Введите x: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y: ");
            double c = Convert.ToDouble(Console.ReadLine());

            var numbers = new object[2];
            numbers[0] = b;
            numbers[1] = c;

          //  var result = method.Invoke(instance, numbers);

            Console.WriteLine(method.Invoke(instance, numbers));

            MethodInfo meth = type.GetMethod("Sub");
         //   var result1 = meth.Invoke(instance, numbers);
            Console.WriteLine(meth.Invoke(instance, numbers));

            Console.ReadLine();
        }
    }
}
/*add и sub*/