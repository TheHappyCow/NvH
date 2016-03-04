using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

class Level : GameObjectList
{
    HexaGrid levelGrid;

    public Level() : base("level")
    {
        levelGrid = new HexaGrid(10, 10, GameEnvironment.AssetManager.GetSprite("Hexagon Tile").Width, GameEnvironment.AssetManager.GetSprite("Hexagon Tile").Height, true, "levelGrid");
        for(int i = 0; i < 10; i++)
            for(int j = 0; j < 10; j++)
                levelGrid.Add(new Tile("Hexagon Tile", "tile"), i, j);
        Objects.Add(levelGrid);
    }
}
