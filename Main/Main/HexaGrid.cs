using Microsoft.Xna.Framework;
using System.Collections.Generic;

class HexaGrid : GameObjectGrid
{
    bool startLeft;
    float offsetX;

    public HexaGrid(int columns, int rows, int cellWidth, int cellHeight, bool startLeft = true, string id = "") : base(columns, rows, cellWidth, cellHeight, id)
    {
        this.startLeft = startLeft;
        offsetX = GameEnvironment.AssetManager.GetSprite("Hexagon Tile").Width * .75f;
    }

    public override void Add(GameObject obj, int x, int y)
    {
        grid[x, y] = obj;
        obj.Parent = this;
        if((startLeft && y % 2 == 0) || (!startLeft && y % 2 == 1))
            obj.Position = new Vector2((x * 1.5f) * cellWidth + offsetX, y * cellHeight / 2);
        else
            obj.Position = new Vector2((x * 1.5f) * cellWidth, y * cellHeight / 2);

    }

    // Top Left Neighbour Tile
    public Tile TLNeighbourTile(Point tilePosition)
    {
        if ((startLeft && tilePosition.Y % 2 == 0) || (!startLeft && tilePosition.Y % 2 == 1))
        {
            try
            {
                return (Tile)grid[tilePosition.X - 1, tilePosition.Y - 1];
            }
            catch
            {
                return null;
            }
        }
        else
        {
            try
            {
                return (Tile)grid[tilePosition.X, tilePosition.Y - 1];
            }
            catch
            {
                return null;
            }
        }

    }

    // Top Right Neighbour Tile
    public Tile TRNeighbourTile(Point tilePosition)
    {
        if ((startLeft && tilePosition.Y % 2 == 0) || (!startLeft && tilePosition.Y % 2 == 1))
        {
            try
            {
                return (Tile)grid[tilePosition.X, tilePosition.Y - 1];
            }
            catch
            {
                return null;
            }
        }
        else
        {
            try
            {
                return (Tile)grid[tilePosition.X + 1, tilePosition.Y - 1];
            }
            catch
            {
                return null;
            }
        }

    }

    // Left Neighbour Tile
    public Tile LNeighbourTile(Point tilePosition)
    {
        try
        {
            return (Tile)grid[tilePosition.X - 1, tilePosition.Y];
        }

        catch
        {
            return null;
        }
    }

    // Right Neighbour Tile
    public Tile RNeighbourTile(Point tilePosition)
    {
        try
        {
            return (Tile)grid[tilePosition.X - 1, tilePosition.Y];
        }

        catch
        {
            return null;
        }
    }

    public Tile BLNeighbourTile(Point tilePosition)
    {
        if ((startLeft && tilePosition.Y % 2 == 0) || (!startLeft && tilePosition.Y % 2 == 1))
        {
            try
            {
                return (Tile)grid[tilePosition.X - 1, tilePosition.Y + 1];
            }
            catch
            {
                return null;
            }
        }
        else
        {
            try
            {
                return (Tile)grid[tilePosition.X, tilePosition.Y + 1];
            }
            catch
            {
                return null;
            }
        }

    }

    public Tile BRNeighbourTile(Point tilePosition)
    {
        if ((startLeft && tilePosition.Y % 2 == 0) || (!startLeft && tilePosition.Y % 2 == 1))
        {
            try
            {
                return (Tile)grid[tilePosition.X, tilePosition.Y + 1];
            }
            catch
            {
                return null;
            }
        }
        else
        {
            try
            {
                return (Tile)grid[tilePosition.X + 1, tilePosition.Y + 1];
            }
            catch
            {
                return null;
            }
        }

    }

    public int GetWidth()
    {
        return (int)(columns * cellWidth * 1.5 + cellWidth * .25);
    }

    public int GetHeight()
    {
        return (int)((rows + 1) * cellHeight * .5);
    }
}
