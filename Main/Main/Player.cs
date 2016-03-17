using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

class Player
{
    protected Faction faction;
    Cursor cursor;

    public enum Faction
    {
        nature,
        humanity
    }

    public Player(Faction faction)
    {
        this.faction = faction;

    }

}
