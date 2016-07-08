using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace DevGUI.Iterator
{
    class ButtonType : ElementType
    {
        Vector2 position;
        SpriteFont font;
        Texture2D texture;
        String text;
        Action action;

        public ButtonType(Vector2 position, Texture2D texture, String text, SpriteFont font)
        {
            this.position = position;
            this.texture = texture;
            this.text = text;
            this.font = font;
        }

        public ButtonType(Vector2 position, Texture2D texture, String text, SpriteFont font, Action action)
        {
            this.position = position;
            this.texture = texture;
            this.text = text;
            this.font = font;
            this.action = action;
        }

        public GuiElement visit(Func<EmptyButton, Label, Action, GuiElement> onButton, Func<Vector2, Texture2D, GuiElement> onEmptyButton, Func<Vector2, string, SpriteFont, GuiElement> onLabel)
        {
            return onButton(new EmptyButton(position, texture), new Label(position, text, font), action);
        }
    }
}
