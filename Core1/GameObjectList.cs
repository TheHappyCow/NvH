using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System;

public class GameObjectList : GameObject
{
    List<GameObject> objects;

    public GameObjectList(string id) : base(id)
    {
        objects = new List<GameObject>();
    }

    public override void HandleInput(InputHelper inputHelper)
    {
        foreach (GameObject obj in objects)
        {
            obj.HandleInput(inputHelper);
        }
    }

    public override void Update(GameTime gameTime)
    {
        foreach(GameObject obj in objects)
        {
            obj.Update(gameTime);
        }
    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch, Vector2 cameraPosition)
    {
        foreach(GameObject obj in objects)
        {
            obj.Draw(gameTime, spriteBatch, cameraPosition);
        }
    }

    public List<GameObject> Objects
    {
        get { return objects; }
    }
}
