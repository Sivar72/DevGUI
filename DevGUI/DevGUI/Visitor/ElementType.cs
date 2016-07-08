using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace DevGUI.Iterator
{
    interface ElementType
    {
        GuiElement visit(
            Func<EmptyButton, Label, Action, GuiElement> onButton,
            Func<Vector2, Texture2D, GuiElement> onEmptyButton, 
            Func<Vector2, string, SpriteFont, GuiElement> onLabel);
    }
}
