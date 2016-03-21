﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Tile : SpriteGameObject
{
    public Tile(string assetName, string id) : base(assetName, 0, id)
    {

    }

    public void SetMenu(TileMenu menu)
    {
            menu.Add(new TileMenuItem());
        menu.Add(new TileMenuItem());
        menu.Add(new TileMenuItem());
        menu.Add(new TileMenuItem());
        menu.Add(new TileMenuItem());
    }
}

