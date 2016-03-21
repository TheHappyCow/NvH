using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Class used for all static data used in the game.
static class GameData
{
    static public GameObject Camera;
    static public HexaGrid LevelGrid;
    //This is the list with all the objects of the current level in it.
    static public GameObjectList LevelObjects;
    static public Cursor cursor;
    static public GameObject selectedTile;
    static public TileMenu tileMenu;
    static public ResourceController resourceController;
    static public void Update(GameTime gameTime)
    {
        LevelObjects.Update(gameTime);
    }
    //This is where the objects in the game (LevelObjects) are drawn.
    static public void DrawGame(GameTime gameTime, SpriteBatch spriteBatch, Vector2 cameraPosition)
    {
        LevelObjects.Draw(gameTime, spriteBatch, Camera.Position);
    }

    //Method that initializes the settings and data used in GameData.
    static public void Initialize()
    {

        LevelObjects = new GameObjectList("levelObjects");
        GameData.LevelGrid = new HexaGrid(10, 40, GameEnvironment.AssetManager.GetSprite("Hexagon Tile").Width, GameEnvironment.AssetManager.GetSprite("Hexagon Tile").Height, true, "levelGrid");
        for (int i = 0; i < 10; i++)
            for (int j = 0; j < 40; j++)
                GameData.LevelGrid.Add(new Tile("Hexagon Tile", "tile"), i, j);
        GameData.LevelObjects.Add(GameData.LevelGrid);
        GameData.Camera = new Camera("camera", new Rectangle(0, 0, GameData.LevelGrid.GetWidth(), GameData.LevelGrid.GetHeight()));
        GameData.LevelObjects.Add(GameData.Camera);
        cursor = new Cursor();
        GameData.LevelObjects.Add(cursor);
        selectedTile = new SpriteGameObject("Hexagon Selected Tile", 0, "selectedTile", 1);
        GameData.LevelObjects.Add(selectedTile);
        selectedTile.Position= new Vector2(-3000,-3000);
        tileMenu = new TileMenu();
        GameData.LevelObjects.Add(tileMenu);
        resourceController = new ResourceController();
        GameData.LevelObjects.Add(resourceController);
    }
    static public void AfterInitialize()
    {

    }
}

