using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevGUI.Visitor
{
    class Some<T> : IOption<T>
    {
        private T value;
        
        public Some(T value)
        {
            this.value = value;
        }

        public U visit<U>(Func<U> onNone, Func<T, U> onSome)
        {
            return onSome(value);
        }

        public bool isNone()
        {
            return false;
        }

        public bool isSome()
        {
            return true;
        }
    }
}
