using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using System;

class PlayingState : Root
{
    Player player;

    public PlayingState()
    {
        //Later nog veranderen dat Initialize pas gebeurd als er daadwerkelijk een game wordt gemaakt (in titlemenu state)
        InitializeGameplay();
        player = new Player(Player.Faction.humanity);
    }
    public void InitializeGameplay()
    {
        GameData.Initialize();
    }

    public void HandleInput(InputHelper inputHelper)
    {
        GameData.LevelObjects.HandleInput(inputHelper);
    }

    public void Update(GameTime gameTime)
    {
        GameData.Update(gameTime);
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Vector2 cameraPosition)
    {
        spriteBatch.Begin();
        GameData.DrawGame(gameTime, spriteBatch, cameraPosition);
        spriteBatch.End();
    }
}
