using Microsoft.Xna.Framework;
using System.Collections.Generic;

class HexaGrid : GameObjectGrid
{
    bool startLeft;

    public HexaGrid(int columns, int rows, int cellWidth, int cellHeight, bool startLeft = true, string id = "") : base(columns, rows, cellWidth, cellHeight, id)
    {
        this.startLeft = startLeft;
        
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
}
