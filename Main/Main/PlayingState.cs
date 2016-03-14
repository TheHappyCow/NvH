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
        Initialize();
        level = new Level(Level.Faction.humanity);
    }
    public void Initialize()
    {
        GameData.Initialize();
    }

    public void HandleInput(InputHelper inputHelper)
    {
        GameData.LevelObjects.HandleInput(inputHelper);
    }

    public void Update(GameTime gameTime)
    {
        GameData.Update(gameTime);
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Vector2 cameraPosition)
    {
        spriteBatch.Begin();
        GameData.DrawGame(gameTime, spriteBatch, cameraPosition);
        spriteBatch.End();
    }
}
