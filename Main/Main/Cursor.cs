using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

class Cursor:SpriteGameObject
    {
    public Cursor() : base("CursorDot", 0, "cursor")
    {
    }
    public override void HandleInput(InputHelper inputHelper)
    {
        base.HandleInput(inputHelper);
        this.Position = inputHelper.MousePosition;
    }
}

