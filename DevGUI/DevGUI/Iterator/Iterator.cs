using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevGUI.Iterator
{
    interface Iterator<T>
    {
        IOption<T> getNext();

        void reset();
    }
}
