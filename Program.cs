using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflectTest.Model;
using ReflectTest.Business;

namespace ReflectTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person() { Address="chengdu,tianfuruanjianyuan" };

            Console.WriteLine(PersonCheck.GetErrorMessage(p1));

            Console.ReadKey();
            
        }
    }
}
