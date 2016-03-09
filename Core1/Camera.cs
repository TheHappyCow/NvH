using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

public class Camera : GameObject
{
    private int dx, dy;
    private const int step = 500;

    public int borderWidth = 100;

    public Camera(string id) : base(id) { }

    public override void HandleInput(InputHelper inputHelper)
    {
        dx = 0;
        dy = 0;

        float mouseX = inputHelper.MousePosition.X;
        float mouseY = inputHelper.MousePosition.Y;

        if (mouseX < borderWidth || inputHelper.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Left))
            dx -= step;

        if (mouseX > GameEnvironment.Screen.X - borderWidth || inputHelper.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Right))
            dx += step;

        if (mouseY < borderWidth || inputHelper.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Up))
            dy -= step;

        if (mouseY > GameEnvironment.Screen.Y - borderWidth || inputHelper.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Down))
            dy += step;
    }

    public override void Update(GameTime gameTime)
    {
        this.position.X += dx * (float)gameTime.ElapsedGameTime.TotalSeconds;
        this.position.Y += dy * (float)gameTime.ElapsedGameTime.TotalSeconds;
        base.Update(gameTime);
    }
}
