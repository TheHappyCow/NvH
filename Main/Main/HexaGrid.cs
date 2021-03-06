﻿using Microsoft.Xna.Framework;
using System.Collections.Generic;

class HexaGrid : GameObjectGrid
{
    bool startLeft;
    int offsetX, offsetY;

    public HexaGrid(int columns, int rows, int cellWidth, int cellHeight, bool startLeft = true, string id = "") : base(columns, rows, cellWidth, cellHeight, id)
    {
        this.startLeft = startLeft;
        offsetX = (int)(GameEnvironment.AssetManager.GetSprite("Hexagon Tile").Width * .75f);
        offsetY = (int)(GameEnvironment.AssetManager.GetSprite("Hexagon Tile").Height * .5f);
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

    /// <summary>
    /// Gets the tile that contains a given point on the map
    /// </summary>
    /// <param name="p">The point on the map</param>
    /// <returns>The corresponding tile</returns>
    public Tile GetTile(Point p)
    {
        int col = p.X / offsetX;
        int colOffset = p.X % offsetX;
        
        int x = col / 2;
        int y = 0;
        if (col % 2 == 0)
            y = ((p.Y + offsetY) / cellHeight) * 2 - 1;
        else
            y = (p.Y / cellHeight) * 2;

        if (colOffset < cellWidth / 4)
        {
            int row = p.Y / offsetY;
            int rowOffset = p.Y % offsetY;
            int dx = (col + 1) % 2;
            if ((row + (col % 2)) % 2 == 0)
            {
                if (rowOffset > colOffset)
                {
                    x -= dx;
                    y++;
                }
            }
            else {
                if (rowOffset + colOffset < offsetY)
                {
                    x -= dx;
                    y--;
                }
            }
        }

        if (x >= 0 && x < columns && y >= 0 && y < rows)
            return (Tile)grid[x, y];
        else
            return null;
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
