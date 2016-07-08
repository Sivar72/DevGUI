using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DevGUI
{
    class Label : GuiElement
    {
        String text;
        SpriteFont font;

        public Label(Vector2 pos, String t, SpriteFont f) : base(pos)
        {        
            text = t;
            font = f;          
        }
        
    }
}
