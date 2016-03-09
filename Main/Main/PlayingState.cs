using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using System;

class PlayingState : Root
{
    Level level;

    public PlayingState()
    {
        level = new Level(Level.Faction.humanity);
    }

    public void HandleInput(InputHelper inputHelper)
    {
        level.HandleInput(inputHelper);
    }

    public void Update(GameTime gameTime)
    {
        level.Update(gameTime);
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Vector2 cameraPosition)
    {
        spriteBatch.Begin();
        level.Draw(gameTime, spriteBatch, cameraPosition);
        spriteBatch.End();
    }
}
