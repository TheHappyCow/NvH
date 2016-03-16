using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System;

public class GameObjectList : GameObject
{
    List<GameObject> gameObjects;

    public GameObjectList(string id) : base(id)
    {
        gameObjects = new List<GameObject>();
    }

    public override void HandleInput(InputHelper inputHelper)
    {
        foreach (GameObject obj in gameObjects)
        {
            obj.HandleInput(inputHelper);
        }
    }

    public override void Update(GameTime gameTime)
    {
        foreach(GameObject obj in gameObjects)
        {
            obj.Update(gameTime);
        }
    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch, Vector2 cameraPosition)
    {
        foreach(GameObject obj in gameObjects)
        {
            obj.Draw(gameTime, spriteBatch, cameraPosition);
        }
    }
    //Method to add an object to the list.
    public void Add(GameObject obj)
    {
        obj.Parent = this;
        for (int i = 0; i < gameObjects.Count; i++)
        {
            if (gameObjects[i].Layer > obj.Layer)
            {
                gameObjects.Insert(i, obj);
                return;
            }
        }
        
        gameObjects.Add(obj);
    }

    //Method to remove an object from the list.
    public void Remove(GameObject obj)
    {
        gameObjects.Remove(obj);
        obj.Parent = null;
        foreach (GameObject o in gameObjects)
        {
            if (o is GameObjectList)
            {
                GameObjectList objList = o as GameObjectList;
                objList.Remove(obj);
            }
        }
    }
    //Method to find a specific object (With the id) in the list.
    public GameObject Find(string id)
    {
        foreach (GameObject obj in gameObjects)
        {
            if (obj.ID == id)
                return obj;
            if (obj is GameObjectList)
            {
                GameObjectList objlist = obj as GameObjectList;
                GameObject subobj = objlist.Find(id);
                if (subobj != null)
                    return subobj;
            }
        }
        return null;
    }

    public List<GameObject> Objects
    {
        get { return gameObjects; }
    }
}
