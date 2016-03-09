using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

public class Camera : GameObject
{
    public Camera(string id) : base(id) { }

    public override void HandleInput(InputHelper inputHelper)
    {
        int dx = 0, dy = 0;

        if (inputHelper.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Left))
            dx -= 1;

        if (inputHelper.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Right))
            dx += 1;

        if (inputHelper.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Up))
            dy -= 1;

        if (inputHelper.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Down))
            dy += 1;

        this.position.X += dx;
        this.position.Y += dy;
    }
}
