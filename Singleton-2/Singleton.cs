using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_2
{
    sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        //Provide thread safety
        private static readonly object InstanceLock = new object();
        private static Singleton GetInstance()
        {
            lock (InstanceLock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }
            return instance;
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine("counter " + counter);
        }

        public void PrintDetail(string message)
        {
            Console.WriteLine(message);
        }

        //class DeirivedSingleton : Singleton
        //{

        //}

        public static void Main(string[] args)
        {
            Singleton fromStudent = GetInstance();
            fromStudent.PrintDetail("This is Student");

            Singleton fromTeacher = GetInstance();
            fromTeacher.PrintDetail("This is Teacher");

            //Singleton.DeirivedSingleton derived = new Singleton.DeirivedSingleton();
            //derived.PrintDetail("This is derived");

        }
    }
}
