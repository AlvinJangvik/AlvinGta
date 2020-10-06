using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    class Map
    {
        private Texture2D house;
        private int[,] map;
        private int x;
        private int y;

        public Map(int width, int height, Texture2D skin)
        {
            house = skin;
            map = new int[width, height];
            x = width;
            y = height;
        }

        public void Creat()
        {
            for(int i = 5; i>=0; i--)
            {
                for(int o = 5; o >= 0; o--)
                {
                    map[o + x/2, i + y/2] = 1;
                }
            }
        }

        public void Draw(SpriteBatch spritebatch)
        {
            for(int i = y-1; i >= 0; i--)
            {
                for (int o = x-1; o >= 0; o--)
                {
                    if (map[i, o] == 1)
                    {
                        spritebatch.Draw(house, new Rectangle(o, i, 5, 5), Color.Black);
                    }
                }
            }
        }
    }
}
