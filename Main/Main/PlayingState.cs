using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using System;

class PlayingState : Root
{
    Level level;
    public GameObject camera;

    public PlayingState()
    {
        camera = new GameObject();
        level = new Level();
    }

    public void HandleInput(InputHelper inputHelper)
    {
        //TODO: CAMERA INPUT HERE
        level.HandleInput(inputHelper);
    }

    public void Update(GameTime gameTime)
    {
        camera.Update(gameTime);
        level.Update(gameTime);
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Vector2 cameraPosition)
    {
        spriteBatch.Begin();
        level.Draw(gameTime, spriteBatch, camera.Position);
        spriteBatch.End();
    }
}
