using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_8_Interface_3
{
    interface Interface1 //узкий интерфейс
    {
        void Method1();

    }

    interface Interface2: Interface1 // широкий интерфейс
    {
      new  void Method1();
           void Method2();

    }
}
