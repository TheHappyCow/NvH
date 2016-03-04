using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

public class MainGame : GameEnvironment
{
    GraphicsDeviceManager graphics;
    SpriteBatch spriteBatch;

    static void Main()
    {
        MainGame game = new MainGame();
        game.Run();
    }

    public MainGame()
    {
        Content.RootDirectory = "Content";
        this.IsMouseVisible = false;
    }

    protected override void LoadContent()
    {
        base.LoadContent();
        gameStateManager.AddGameState("playingState", new PlayingState());
        gameStateManager.SwitchTo("playingState");
    }
}