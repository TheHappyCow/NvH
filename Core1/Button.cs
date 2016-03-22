using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

//Make button
public class Button : SpriteGameObject
{
    protected bool pressed;

    //Button Text
    protected string text;
    protected SpriteFont spriteFont, smallFont, bigFont;
    protected Color textColor;
    protected Vector2 textPosition;
    protected bool selected;
    protected bool selectedSet;

    public Vector2 TextPosition
    {
        get { return textPosition; }
        set { textPosition = value; }
    }

    public Color TextColor
    {
        get { return textColor; }
        set { textColor = value; }
    }

    public bool Selected
    {
        get { return selected; }
        set { selected = value; selectedSet = true; }
    }

    public bool Pressed
    {
        get { return pressed; }
    }


    public Button(string assetName, string font, string smallFont, int sheetIndex = 0, string id = "", int layer = 0) : base(assetName, sheetIndex, id)
    {
        //Button State
        pressed = false;

        //Button Origin
        this.Origin = new Vector2(spriteSheet.Width / 2, spriteSheet.Height / 2);

        //Button Text
        text = null;

        textColor = Color.Black;

        textPosition = new Vector2(-(spriteFont.MeasureString(text).X / 2), -(spriteFont.MeasureString(text).Y / 2));
    }

    public override void HandleInput(InputHelper ih)
    {
        //Determines button state
        if (ih.MouseInBox(BoundingBox))
        {
            selected = true;
            selectedSet = false;
        }
        else if (!selectedSet)
            selected = false;

        if (selected)
        {
            if ((ih.MouseLeftButtonPressed() && ih.MouseInBox(BoundingBox)) || ih.KeyPressed(Keys.Enter))
            {
                pressed = true;
                textColor = Color.Purple;
            }
            if ((ih.MouseLeftButtonDown() && ih.MouseInBox(BoundingBox)) || ih.IsKeyDown(Keys.Enter))
                spriteSheet.SheetIndex = 1;
            else
            {
                spriteSheet.SheetIndex = 2;
                textColor = Color.White;
                spriteFont = smallFont;
                textPosition = new Vector2(-(smallFont.MeasureString(text).X / 2), -(smallFont.MeasureString(text).Y / 2));
            }
        }
        else
        {
            spriteSheet.SheetIndex = 0;
            textColor = Color.Black;
            spriteSheet.Scale = 1.0f;
            spriteFont = bigFont;
            textPosition = new Vector2(-(bigFont.MeasureString(text).X / 2), -(bigFont.MeasureString(text).Y / 2));
            pressed = false;
        }
    }



    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch, Vector2 cameraPosition)
    {
        //base
        base.Draw(gameTime, spriteBatch, cameraPosition);

        if(text!= null) 
         spriteBatch.DrawString(spriteFont, text, this.Position + textPosition, textColor);
    }
}
