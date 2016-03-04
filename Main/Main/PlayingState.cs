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

    public override void HandleInput(InputHelper inputHelper)
    {
        //TODO: CAMERA INPUT HERE
        level.HandleInput(inputHelper);
    }

    public override void Update(GameTime gameTime)
    {
        camera.Update(gameTime);
        level.Update(gameTime);
    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        level.Draw(gameTime, spriteBatch, camera.Position);
    }
}
