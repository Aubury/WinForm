using SampleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace ModulesInAction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly asm = Assembly.Load(AssemblyName.GetAssemblyName("SampleLibrary.dll"));
            //Module mod = asm.GetModule("SampleLibrary.dll");
            //Console.WriteLine("Объявленные типы данных:");
            //foreach(Type t in mod.GetTypes())
            //{
            //    Console.WriteLine(t.FullName);
            //}
            //Type Person = mod.GetType("SampleLibrary.Person") as Type;

            //object person = Activator.CreateInstance(Person, new object[] { "Иван", "Иванов", 30 });
            //Person.GetMethod("Print").Invoke(person, null);
        }
    }
}
