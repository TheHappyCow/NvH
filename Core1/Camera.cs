using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

public class Camera : GameObject
{
    private int dx, dy;
    private const int xStep = 600;
    private const int yStep = 400;

    private int borderWidth = 100;
    private Rectangle bounds;

    public Camera(string id, Rectangle bounds) : base(id) {
        this.bounds = bounds;
    }

    public override void HandleInput(InputHelper inputHelper)
    {
        dx = 0;
        dy = 0;

        float mouseX = inputHelper.MousePosition.X;
        float mouseY = inputHelper.MousePosition.Y;

        if (mouseX < borderWidth || inputHelper.IsKeyDown(Keys.Left))
            dx -= xStep;

        if (mouseX > GameEnvironment.Screen.X - borderWidth || inputHelper.IsKeyDown(Keys.Right))
            dx += xStep;

        if (mouseY < borderWidth || inputHelper.IsKeyDown(Keys.Up))
            dy -= yStep;

        if (mouseY > GameEnvironment.Screen.Y - borderWidth || inputHelper.IsKeyDown(Keys.Down))
            dy += yStep;
    }

    public override void Update(GameTime gameTime)
    {
        float x = this.position.X + dx * (float)gameTime.ElapsedGameTime.TotalSeconds;
        float y = this.position.Y + dy * (float)gameTime.ElapsedGameTime.TotalSeconds;
        x = Math.Max(x, bounds.Left);
        x = Math.Min(x, bounds.Right - GameEnvironment.Screen.X);
        y = Math.Max(y, bounds.Top);
        y = Math.Min(y, bounds.Bottom - GameEnvironment.Screen.Y);
        this.position.X = x;
        this.position.Y = y;
        base.Update(gameTime);
    }
}
