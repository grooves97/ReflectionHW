using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Type typeConsole = typeof(Console);
            MethodInfo[] methodConsole = typeConsole.GetMethods();

            foreach (MethodInfo mi in methodConsole)
            {
                Console.WriteLine($"{mi.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("TASK 2");

            User user = new User("Aslan","Nurseitov",123456,"Lenina");
            Type typeUser = typeof(User);

            foreach (PropertyInfo property in typeUser.GetProperties())
            {
                Console.WriteLine($"{property.Name}={property.GetValue(user,null)}");
            }

        }
    }
}
