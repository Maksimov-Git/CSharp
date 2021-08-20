using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_8_Interface_2
{
    interface Interfaces1
    {
        void Method1();
       
    }
    interface Interfaces2
    {
        void Method1();
    }

    interface Interfaces3
    {// Method 2  в даннном интерфейсе имеет другую сигнатуру 
        int Method1(int I);
    }

}
