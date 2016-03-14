using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Class used for all static data used in the game.
static class GameData
{

    //This is the list with all the objects of the current level in it.
    static public GameObjectList LevelObjects;
    static public void Update(GameTime gameTime)
    {
        LevelObjects.Update(gameTime);
    }
    //This is where the objects in the game (LevelObjects) are drawn.
    static public void DrawGame(GameTime gameTime, SpriteBatch spriteBatch, Vector2 cameraPosition)
    {
        LevelObjects.Draw(gameTime, spriteBatch, cameraPosition);
    }
    //Method that initializes the settings and data used in GameData.
    static public void Initialize()
    {
        LevelObjects = new GameObjectList("levelObjects");
    }
}

