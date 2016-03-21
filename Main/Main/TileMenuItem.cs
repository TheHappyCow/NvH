using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class TileMenuItem : SpriteGameObject
{
    public TileMenuItem() : base("TileMenuItem", 0, "test", 5)
    {

    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch, Vector2 cameraPosition)
    {
        base.Draw(gameTime, spriteBatch, Vector2.Zero);
    }
}
