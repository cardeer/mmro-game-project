﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace game_final.Base
{
    abstract class SceneRenderer
    {
        protected void DrawSprite(Base.Sprite sprite)
        {
            Environments.Global.SpriteBatch.Draw(
                sprite.Instance,
                sprite.Position,
                null,
                sprite.DrawColor,
                sprite.Rotation,
                sprite.Origin,
                sprite.Scale,
                SpriteEffects.None,
                0f
            );
        }

        public abstract void Update();
        public abstract void Draw();
    }
}