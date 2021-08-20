using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_8_Interface_3
{
    class A : Object, Interface2
    {
        public void Method1()
        {
            Console.WriteLine(" метод1 интерфейса 1");
        }
        void Interface2.Method1()
        {

            Console.WriteLine(" метод1 интерфейса 2");
        }
        public void Method2()
        {
            Console.WriteLine(" метод2 интерфейса 2");
        }

    }

    class Program
    {

       
        static void Main(string[] args)
        {
            A Obj = new A();
            Obj.Method1();
            Obj.Method2();
            Console.WriteLine(" ");
            // апкаст позволяет вызвать только Method1
            Interface1 Int = Obj as Interface1;
            Int.Method1();
            Console.WriteLine(" ");
            // Оператор as явным образом преобразует результат выражения в указанный ссылочный
            //или поддерживающий значения NULL тип. Если такое преобразование невозможно,
            //оператор as возвращает значение null.
            Console.WriteLine(" ");
            Interface2 Int1 = Obj as Interface2;
            Int1.Method1();
            Int1.Method2();
            Console.ReadKey();
        }
    }
}
