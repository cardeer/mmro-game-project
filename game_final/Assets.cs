﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace game_final
{
    /// <summary>
    /// Store all asset references
    /// </summary>
    static class Assets
    {
        private static ContentManager s_content;
        private static SpriteBatch s_spriteBatch;
        private static GraphicsDevice s_graphics;

        public static Sprites.Shooter Shooter;
        public static Scenes.Playing PlayingScene;

        /// <summary>
        /// Load all assets
        /// </summary>
        /// <param name="content"></param>
        /// <param name="graphics"></param>
        public static void Initialize(ContentManager content, SpriteBatch spriteBatch, GraphicsDevice graphics)
        {
            s_content = content;
            s_spriteBatch = spriteBatch;
            s_graphics = graphics;

            loadTextures();
            createSprites();
        }

        private static void loadTextures() {
            Textures.LightBlueBall = s_content.Load<Texture2D>("Balls/light_blue");
        }

        private static void createSprites()
        {
            Shooter = new Sprites.Shooter(s_spriteBatch, s_graphics);
            PlayingScene = new Scenes.Playing(s_spriteBatch, s_graphics);
        }
    }
}
