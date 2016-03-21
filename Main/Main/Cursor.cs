using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

class Cursor : SpriteGameObject
    {
    protected bool hasClickedTile;
    protected Tile currentTile;

    public Cursor() : base("CursorDot", 0, "cursor",5)
    {
        hasClickedTile = false;
    }
    public override void HandleInput(InputHelper inputHelper)
    {
        base.HandleInput(inputHelper);
        this.Position = inputHelper.MousePosition;

        Point position = new Point((int)(inputHelper.MousePosition.X + GameData.Camera.Position.X), (int)(inputHelper.MousePosition.Y + GameData.Camera.Position.Y));

        if (!hasClickedTile) {
            currentTile = GameData.LevelGrid.GetTile(position);
            if (currentTile != null)
                GameData.selectedTile.Position = currentTile.Position;
        }
        //Create popup and stop hovering tiles 
        if (inputHelper.MouseLeftButtonPressed()&&currentTile!=null&&!hasClickedTile)
        {
            hasClickedTile = true;
        }
        //If player clicks again while there is a menu popup and the mouse is not in the boundingbox of the menu, hasClickedTile = false and the menu should
        //disappear.   DOESNT WORK YET, GOTTA HAVE MENU FIRST TO TEST BETTER.
        else if(inputHelper.MouseLeftButtonPressed()&&hasClickedTile)
        {
            hasClickedTile = false;           
        }

    }

    public override void Draw(GameTime gameTime, Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch, Vector2 cameraPosition)
    {
        if (spriteSheet == null)
            return;
        spriteSheet.Draw(spriteBatch, Position, new Vector2(0,0));
    }
}

