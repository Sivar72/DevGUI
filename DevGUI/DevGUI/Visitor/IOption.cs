using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevGUI
{
    public interface IOption<T>
    {
	    U visit<U>(Func<U> onNone, Func<T, U> onSome);

        Boolean isSome();

        Boolean isNone();
    }
}
