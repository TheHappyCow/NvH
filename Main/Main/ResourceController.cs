using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class ResourceController : GameObject
{
    Timer passiveResourceTimer;

    public ResourceController() : base("resourceController")
    {
        passiveResourceTimer = new Timer(1);
    }
    public override void Update(GameTime gameTime)
    {
        passiveResourceTimer.Update(gameTime);
        checkPassiveTimer();
    }
    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch, Vector2 cameraPosition)
    {
    }

    protected void checkPassiveTimer()
    {
        if (passiveResourceTimer.Ended)
        {
            //Give players resources
            //Reset timer
            passiveResourceTimer.Reset();
        }
    }
}

