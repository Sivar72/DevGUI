using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevGUI.Visitor
{
    class None<T> : IOption<T>
    {
        public U visit<U>(Func<U> onNone, Func<T, U> onSome)
        {
            return onNone();
        }

        public bool isNone()
        {
            return true;
        }

        public bool isSome()
        {
            return false;
        }
    }
}
