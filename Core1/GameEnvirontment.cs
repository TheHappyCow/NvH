using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class GameEnvironment : Game
{
    protected SpriteBatch spriteBatch;
    protected GraphicsDeviceManager graphics;
    protected InputHelper inputHelper;
    protected static GameStateManager gameStateManager;
    protected static AssetManager assetManager;
    protected static Point screen;
    public static GraphicsDevice graphicsDevice;

    public GameEnvironment()
    {
        inputHelper = new InputHelper();
        gameStateManager = new GameStateManager();
        assetManager = new AssetManager(Content);
        graphics = new GraphicsDeviceManager(this);
    }

    protected override void LoadContent()
    {
        graphicsDevice = graphics.GraphicsDevice;
        DrawingHelper.Initialize(this.GraphicsDevice);
        spriteBatch = new SpriteBatch(GraphicsDevice);
        screen = new Point(GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
    }

    public static GraphicsDevice Graphics
    {
        get { return graphicsDevice; }
    }

    public static Point Screen
    {
        get { return GameEnvironment.screen; }
    }

    public static AssetManager AssetManager
    {
        get { return assetManager; }
    }

    public static GameStateManager GameStateManager
    {
        get { return gameStateManager; }
    }

    public InputHelper InputHelper
    {
        get { return inputHelper; }
    }

    protected void HandleInput()
    {
        inputHelper.Update();
        gameStateManager.HandleInput(inputHelper);
    }

    protected override void Update(GameTime gameTime)
    {
        HandleInput();
        gameStateManager.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        graphics.GraphicsDevice.Clear(Color.Black);
        gameStateManager.Draw(gameTime, spriteBatch);
    }
}

