using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

public class SpriteSheet
{
    protected Texture2D sprite;
    protected int sheetIndex;
    protected int sheetColumns;
    protected int sheetRows;
    protected bool mirror;

    public SpriteSheet(string assetname = "", int sheetIndex = 0)
    {
        sprite = GameEnvironment.AssetManager.GetSprite(assetname);
        this.sheetIndex = sheetIndex;
        this.sheetColumns = 1;
        this.sheetRows = 1;

        //extract number of sheet elements from the assetname
        string[] assetSplit = assetname.Split('@');
        if (assetSplit.Length <= 1)
            return;

        string sheetnrData = assetSplit[assetSplit.Length - 1];
        string[] colrow = sheetnrData.Split('x');
        this.sheetColumns = int.Parse(colrow[0]);
        if (colrow.Length == 2)
            this.sheetRows = int.Parse(colrow[1]);
    }

    public void Draw(SpriteBatch spriteBatch, Vector2 position, Vector2 origin)
    {
        int columnIndex = sheetIndex % sheetColumns;
        int rowIndex = sheetIndex / sheetColumns % sheetRows;
        Rectangle spritePart = new Rectangle(columnIndex * this.Width, rowIndex * this.Height, this.Width, this.Height);
        SpriteEffects spriteEffects = SpriteEffects.None;

        spriteBatch.Draw(sprite, position, spritePart, Color.White, 0.0f, origin, 1.0f, spriteEffects, 0.0f);
    }

    public Texture2D Sprite
    {
        get { return sprite; }
    }

    public int Width
    {
        get { return sprite.Width / sheetColumns; }
    }

    public int Height
    {
        get { return sprite.Height / sheetRows; }
    }
}

