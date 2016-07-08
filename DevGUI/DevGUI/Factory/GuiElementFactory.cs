using DevGUI.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevGUI.Factory
{
    class GuiElementFactory
    {
        ElementType type;

        public GuiElementFactory(ElementType type)
        {
            this.type = type;
        }

        public GuiElement Load()
        {
            return new GuiElement();
        }
    }   
}
