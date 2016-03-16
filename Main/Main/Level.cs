using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

class Level : GameObjectList
{
    protected Faction faction;
    Cursor cursor;

    public enum Faction
    {
        nature,
        humanity
    }

    public Level(Faction faction) : base("level")
    {
        this.faction = faction;
        GameData.LevelGrid = new HexaGrid(10, 40, GameEnvironment.AssetManager.GetSprite("Hexagon Tile").Width, GameEnvironment.AssetManager.GetSprite("Hexagon Tile").Height, true, "levelGrid");
        for(int i = 0; i < 10; i++)
            for(int j = 0; j < 40; j++)
                GameData.LevelGrid.Add(new Tile("Hexagon Tile", "tile"), i, j);
        GameData.LevelObjects.Add(GameData.LevelGrid);
        GameData.Camera = new Camera("camera", new Rectangle(0, 0, GameData.LevelGrid.GetWidth(), GameData.LevelGrid.GetHeight()));
        GameData.LevelObjects.Add(GameData.Camera);
        cursor = new Cursor();
        GameData.LevelObjects.Add(cursor);
    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch, Vector2 cameraPosition)
    {
        base.Draw(gameTime, spriteBatch, cameraPosition);
    }
}
