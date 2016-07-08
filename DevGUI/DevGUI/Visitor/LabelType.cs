using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DevGUI.Iterator
{
    class LabelType : ElementType
    {
        Vector2 position;
        String text;
        SpriteFont font;

        public LabelType(Vector2 pos, String text, SpriteFont font)
        {
            this.position = pos;
            this.text = text;
            this.font = font;
        }

        public GuiElement visit(Func<EmptyButton, Label, Action, GuiElement> onButton, Func<Vector2, Texture2D, GuiElement> onEmptyButton, Func<Vector2, string, SpriteFont, GuiElement> onLabel)
        {
            return onLabel(position, text, font);
        }
    }
}
