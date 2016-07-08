using DevGUI.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevGUI.Factory
{
    class FormLoader
    {
        List<ElementType> elements;

        public FormLoader(List<ElementType> elements)
        {
            this.elements = elements;
        }

        public GuiElementsFactory Load()
        {
            return new GuiElementsFactory(elements);
        }
    }
}
