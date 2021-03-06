﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public interface Root
{
    void HandleInput(InputHelper inputHelper);

    void Update(GameTime gameTime);

    void Draw(GameTime gameTime, SpriteBatch spriteBatch, Vector2 cameraPosition);
}