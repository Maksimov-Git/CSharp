using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_8_Interface_2
{
    class A : Object, Interfaces1, Interfaces2, Interfaces3 
    {
        public void Method1()
        {
            Console.WriteLine("интерфейс 1");
        }
        // явное указание имени интерфейса в имени метода
        // есть еще техника объединененной реализации одноименных методов.
         void Interfaces2.Method1()
        {
            Console.WriteLine("интерфейс 2");
        }
        public  int Method1(int i)
        {
            return 4;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {// создаем экземпляр класса и приводим его к базовому типу interfaes 1
            // инкапсуляция методов за счет апкаста
            Interfaces1 Int = new A();
            Int.Method1(); // вызвать можно только этот метод


            Interfaces2 Int1 = new A();
            // при апкасте мы можем вызвать метод, который при реализации "помечен" как private 
            Int1.Method1();

            Console.ReadKey();
        }
    }
}
