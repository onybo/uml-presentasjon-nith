using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClassA
    {
        private ClassB _b;
        public ClassA(ClassB b)
        {
            _b = b;
        }

        public void DoSomething()
        {
            int sum = 0;
            for (var i = 0; i < 10; i++)
            {
                sum += _b.MethodB();                
            }
            Console.WriteLine("sum er :" + sum);
        }
    }
}
