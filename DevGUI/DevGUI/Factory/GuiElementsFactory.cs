using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DevGUI.Iterator;

namespace DevGUI.Factory
{
    class GuiElementsFactory<T> : Iterator<T>
    {
        List<ElementType> elements;
        int index;

        public GuiElementsFactory(List<ElementType> elements)
        {
            this.elements = elements;
        }      

        public void reset()
        {
            throw new NotImplementedException();
        }

        IOption<T> Iterator<T>.getNext()
        {            
            throw new NotImplementedException();
        }
    }
}
