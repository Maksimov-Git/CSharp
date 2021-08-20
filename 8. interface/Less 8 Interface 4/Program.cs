using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Less_8_Interface_4
{

    public interface Id
    {
         void SayMyName();
    }

    public class Rectangle : Id
    {
        public void SayMyName()
        {
            Console.WriteLine("i'm rectangle");
        }
    }
    public class Human : Id
    {
        public void SayMyName()
        {
            Console.WriteLine("я не виноват, отпустите меня. Что здесь длает треугольник");
        }
    }
    public class Dog : Id
    {
        public void SayMyName()
        {
            Console.WriteLine(" Гав ");
        }   
    }
    public class Alexey : Id
    {
        public void SayMyName()
        {
            Console.WriteLine(" Нет, я мне не интересны ваши товары ");
        }

        
    }
       


    class Program
    {
        static void Main(string[] args)
        {
            ArrayList jail = new ArrayList();

            jail.Add( new Rectangle());
            jail.Add(new Human());
            jail.Add(new Dog());
            jail.Add(new Alexey());
            jail.Add(new Random());



            foreach (object prisoner in jail)
            {

                if (prisoner is Id)
                {
                    Id temp = prisoner as Id;
                    temp.SayMyName();
                }
                else { Console.WriteLine("не умеет говорить"); }
                
            }

            Console.ReadKey();


        }
    }
}
