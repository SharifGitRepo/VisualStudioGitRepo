using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    sealed class Singleton
    {
        private static Singleton Instance;
        private static int counter = 0;
        private static readonly object InstanceLock = new object();
        private static Singleton GetInstance()
        {
            lock (InstanceLock)
            {
                if (Instance == null)
                {
                    Instance = new Singleton();
                }
            }
            return Instance;
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter = {0}", counter);
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        //class DerivedSingleton : Singleton
        //{
            
        //}
        public static void Main(string[] args)
        {
            Singleton fromStudent = GetInstance();
            fromStudent.PrintDetails("This is from Student");

            Singleton fromTeacher = GetInstance();
            fromTeacher.PrintDetails("This is from Teacher");

           // Singleton.DerivedSingleton fromDerived = new Singleton.DerivedSingleton();
           // fromDerived.PrintDetails("This is from derived");

            Console.ReadLine();
        }
    }
}
