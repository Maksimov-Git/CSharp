using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_Generics_1
{
    // Нам известно, что при создании методов мы можем указывать список параметров 
    // создаем класс пaрaметризированый одинм указателем места заполнения типа 
    class MyClass<T>// указатель места заполнения типа
    {
        public T field;

        public void Method()
        {
            Console.WriteLine(field.GetType());
        }
    }


    class Program
    {
        static void Main(string[] args)
        { // создаем экземпляр класса и закрываем его типом int 
          //  создаем эклепмляр класса и в качестве параметра передаем тип int 
            MyClass<int> M1 = new MyClass<int>();
            M1.Method();


            MyClass<long> M2 = new MyClass<long>();
            M2.Method();

            MyClass<string> M3 = new MyClass<string>();
            M3.field = "ADC";
            M3.Method();

            Console.ReadKey();
        }
    }
}
