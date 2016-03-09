using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

public class SpriteGameObject : GameObject
{
    protected Vector2 origin;
    protected SpriteSheet spriteSheet;

    public SpriteGameObject(string assetname, int sheetIndex = 0, string id = "")
    {
        if (assetname != "")
            spriteSheet = new SpriteSheet(assetname, sheetIndex);          
    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch, Vector2 cameraPosition)
    {
        if (spriteSheet == null)
            return;
        spriteSheet.Draw(spriteBatch, Position, cameraPosition);
    }

    public SpriteSheet SpriteSheet
    {
        get { return spriteSheet; }
    }

    public int Width
    {
        get { return spriteSheet.Width; }
    }

    public int Height
    {
        get { return spriteSheet.Height; }
    }

    public Vector2 Origin
    {
        get { return this.origin; }
        set { this.origin = value; }
    }

    //Returns the boundingbox of the sprite.
    public Rectangle BoundingBox
    {
        get
        {
            int left = (int)(Position.X - origin.X);
            int top = (int)(Position.Y - origin.Y);
            return new Rectangle(left, top, Width, Height);
        }
    }
}