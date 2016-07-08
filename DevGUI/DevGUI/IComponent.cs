using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;


namespace DevGUI
{
    interface IComponent
    {
        void update(float dt);

        void draw(SpriteBatch spriteBatch);
    }
}
