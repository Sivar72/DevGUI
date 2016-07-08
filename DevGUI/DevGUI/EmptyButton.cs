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
    class EmptyButton : GuiElement
    {
        Texture2D texture;
        Vector2 scale;
        Boolean is_clicked;
        Boolean waiting_for_up;
        float count_down;
        float max_count_down;

        public EmptyButton(Vector2 pos, Texture2D t) : base(pos)
        {
            this.texture = t;      
        }

    }
}
