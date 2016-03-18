using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

//Draws string object
public class TextGameObject : GameObject
{
    protected SpriteFont spriteFont;
    protected Color color;
    protected string text;

    public Color Color
    {
        get { return color; }
        set { color = value; }
    }

    public string Text
    {
        get { return text; }
        set { text = value; }
    }

    public Vector2 Size => spriteFont.MeasureString(text);

    public TextGameObject(string assetname, int layer = 0, string id = "")
        : base(id, layer)
    {
        if (assetname != "")
            this.spriteFont = GameEnvironment.AssetManager.GetFont(assetname);

        color = Color.Black;
    }


    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch, Vector2 cameraPosition)
    {
        if (this.text == null)
            this.text = "null";

        if (visible)
            spriteBatch.DrawString(spriteFont, text, this.Position, color);
    }
}

