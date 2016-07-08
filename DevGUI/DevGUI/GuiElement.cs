using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DevGUI
{
   abstract class GuiElement : IComponent
    {
        Vector2 position;       

        public GuiElement(Vector2 pos)
        {
            this.position = pos;
        }

        public void update(float dt)
        {
            throw new NotImplementedException();
        }

        public void draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
