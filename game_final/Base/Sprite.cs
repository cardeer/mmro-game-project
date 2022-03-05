﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;

namespace game_final.Base
{
    class Sprite : Object
    {
        public Vector2 Origin;
        public Texture2D Instance;
        public float Scale = 1f;

        protected Color[] _colorArray;
        protected Color _color = Color.Transparent;

        public bool isDestroyed = false;

        protected Sprite(GraphicsDevice graphics, int width, int height)
        {
            Position = new Vector2(0, 0);
            Origin = new Vector2(0, 0);

            _width = width;
            _height = height;

            Instance = new Texture2D(graphics, width, height);

            _colorArray = new Color[Instance.Width * Instance.Height];
        }

        protected Sprite(Texture2D texture, int size)
        {
            Position = new Vector2(0, 0);
            Origin = new Vector2(0, 0);

            Instance = texture;

            Scale = (float)size / texture.Width;

            _width = size;
            _height = (int)(texture.Height * Scale);

            _colorArray = new Color[Instance.Width * Instance.Height];
        }

        public Color Color
        {
            get { return _color; }
        }

        public Color DrawColor {
            get { return _color != Color.Transparent ? _color : Color.White; }
        }

        public void SetColor(Color color)
        {
            _color = color;

            for (int i = 0; i < _colorArray.Length; i++)
            {
                _colorArray[i] = color;
            }

            Instance.SetData(_colorArray);
        }

        public void SetOrigin(float x, float y)
        {
            Origin.X = x;
            Origin.Y = y;
        }

        public void Destroy()
        {
            isDestroyed = true;
        }
    }
}
