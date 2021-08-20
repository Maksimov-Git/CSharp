using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_8__abstract
{
    class Program
    {
        static void Main(string[] args)
        {
           // Figure F = new Figure();

            Figure[] FigArr = new Figure[3];

            FigArr[0] = new Square();
            FigArr[1] = new Rectangle();
            FigArr[2] = new Circle();
           // FigArr[3] = new Figure();
          //  FigArr[4] = new Figure();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(FigArr[i].ToString());
            }
            Console.WriteLine();


            foreach (Figure C in FigArr)
            {
                Console.WriteLine(C.ToString());
            }

            Console.ReadKey();
        }
    }
}
