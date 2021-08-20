using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_8__abstract
{
    public delegate void EventDelegat();
    abstract class Figure
    {

        public abstract event EventDelegat OnDrowing;
        public abstract float P();
        public abstract float S();
    }

    class Rectangle: Figure
    {
        public override float P()
       {
           return 4;
       }
        public override float S()
        {
            return 4;
        }

        public override event EventDelegat OnDrowing
        {
            add
            {

            }
            remove
            {

            }

        }

    }

    class Square : Rectangle
    {
      //  public abstract void Method();
        public override float P()
        {
            return 4;
        }
        public override float S()
        {
            return 4;
        }

        public override event EventDelegat OnDrowing
        {
            add
            {

            }
            remove
            {

            }

        }

    }


    class Circle : Figure
    {
        public override float P()
        {
            return 4;
        }
        public override float S()
        {
            return 4;
        }

        public override event EventDelegat OnDrowing
        {
            add
            {

            }
            remove
            {

            }

        }

    }
}
