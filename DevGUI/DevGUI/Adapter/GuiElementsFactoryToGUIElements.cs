using DevGUI.Factory;
using DevGUI.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevGUI.Adapter
{
    class GuiElementsFactoryToGUIElements<T> : Iterator<T>
    {
        List<IOption<GuiElement>> factory;
        int index;
        IOption<GuiElementFactory> currentFactory;

        public GuiElementsFactoryToGUIElements(GuiElementsFactory<T> ef)
        {
            index = -1;
        }

        public IOption<GuiElement> getNext()
        {
            index++;
            if (index < factory.Count)
                return factory.ElementAt(index);
            else
                return null;
        }     

        public void reset()
        {
            index = -1;            
        }

        IOption<T> Iterator<T>.getNext()
        {
            throw new NotImplementedException();
        }
    }
}
