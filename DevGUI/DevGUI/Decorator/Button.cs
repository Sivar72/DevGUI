using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevGUI.Decorator
{
    class Button
    {
        EmptyButton button;
        Label label;
        Action action;

        public Button(EmptyButton button, Label label, Action action) 
        {
            this.button = button;
            this.label = label;
            this.action = action;            
        }
    }
}
