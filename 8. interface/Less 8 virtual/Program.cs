using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_8_virtual
{
    class A
    {
        public virtual void Method()
        {
            Foo();
        }

       public virtual void Foo()
        {
            Console.Write("Class A");
        }
    }
    class B : A
    {
        public override void Foo()
        {
            
            Console.Write("Class B");
            Foo();
        }
    }
    //======================================
    class Program
    {
        static void Main(string[] args)

        {


            A obj2 = new B();
            

            obj2.Foo();




            // A obj3 = new B();
            // obj3.Foo();
            Console.ReadKey();
        }
    }
}
